using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MoveLegRef.Bussines
{
    public class SocketService : ISocketService
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        private int port = 5000;

        int repeticionesDeMedicion = 10; //Repeticiones de Calibracion.

        public bool SetupServer()
        {
            try
            {
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                serverSocket.Listen(0);
                serverSocket.BeginAccept(AcceptCallback, null);
                return true;
            }
            catch (Exception error)
            {
                return false;
            }

        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;
            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }
            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        public void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;
            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {

                //ActualizarRepeticiones();

                //MessageBox.Show("Se ha desconectado el dispositivo");

                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            //MessageBox.Show("REcibimos:" + text);
            //string[] renglones = text.Split('q');
            //foreach (string renglon in renglones )
            //{string[] messagges = renglon.Split('|');

            string[] messagges = text.Split('|');
            if (messagges.Length > 1)
            {
                try
                {
                    //MessageBox.Show(messagges[1]);
                    if (messagges[1] == "Tobillo")
                    {

                        string[] datos = messagges[2].Split(',');
                        PosicionT[cont_T, 0] = Convert.ToInt32(datos[0]) - 16;
                        TiemposT[cont_T, 0] = Convert.ToDouble(datos[2]);
                        PosicionT[cont_T, 1] = Convert.ToInt32(datos[1]) - 16;
                        TiemposT[cont_T, 1] = Convert.ToDouble(datos[3]);

                        sumatoria_min_PT = sumatoria_min_PT + PosicionT[cont_T, 1];
                        sumatoria_max_PT = sumatoria_max_PT + PosicionT[cont_T, 0];
                        sumatoria_tiempo_mMT = sumatoria_tiempo_mMT + TiemposT[cont_T, 0];
                        sumatoria_tiempo_MmT = sumatoria_tiempo_MmT + TiemposT[cont_T, 1];

                        cont_T = cont_T + 1;
                        LB_PromDesTobillo.Text = Convert.ToString(cont_T) + "/" + Convert.ToString(NRMedicion); ;

                        //if (cont_T == NRT)
                        if (cont_T == NRMedicion)
                        {
                            Promedio_min_PT = sumatoria_min_PT / NRMedicion;/// NRT;
                            Promedio_max_PT = sumatoria_max_PT / NRMedicion;/// NRT;
                            Promedio_MmT = sumatoria_tiempo_MmT / NRMedicion;/// NRT;
                            Promedio_mMT = sumatoria_tiempo_mMT / NRMedicion;/// NRT;

                            //Mayor a menor dorsiflexion
                            vel_prom_med_TDF = (Promedio_max_PT - Promedio_min_PT) / (Promedio_MmT / 1000);
                            vel_prom_med_TPF = (Promedio_max_PT - Promedio_min_PT) / (Promedio_mMT / 1000);


                            //s1.lbl
                            MessageBox.Show("Mediciones completas");

                            LB_PromDesRodilla.Text = Convert.ToString(Decimal.Truncate(Promedio_min_PR, 2)) + " - " + Convert.ToString(Decimal.Truncate(Promedio_max_PR, 2)) + " cm";//"{0:N2} - {1:N2}", Promedio_min_PR , Promedio_max_PR;
                            LB_PromDesTobillo.Text = Convert.ToString(Decimal.Truncate(Promedio_min_PT, 2)) + " - " + Convert.ToString(Decimal.Truncate(Promedio_max_PT, 2)) + " °";//Convert.ToString(Promedio_min_PT) + "-" + Convert.ToString(Promedio_max_PT);
                            LB_PromVelRodilla.Text = Convert.ToString(Decimal.Truncate(vel_prom_med_RF, 2)) + "cm/s";//Convert.ToString(vel_prom_med_RF);
                            LB_PromVelRodillaEstiramiento.Text = Convert.ToString(Decimal.Truncate(vel_prom_med_RE, 2)) + "cm/s";//Convert.ToString(vel_prom_med_RE);
                            LB_PromVelTobillo.Text = Convert.ToString(Decimal.Truncate(vel_prom_med_TPF, 2)) + "°/s";//Convert.ToString(vel_prom_med_TPF);
                            LB_PromVelTobilloDorsiflexion.Text = Convert.ToString(Decimal.Truncate(vel_prom_med_TDF, 2)) + "°/s";//Convert.ToString(vel_prom_med_TDF);
                            gb_IniciarTerapia.Enabled = true;

                            //velocidad maxima tobillo 100°/s

                            double maximo_vel_rodilla = Math.Max(vel_prom_med_RF, vel_prom_med_RE);
                            //velocidad maxima rodilla 4.54 cm/s
                            int disminucion_minima_rodilla = Convert.ToInt32((100 - ((100 * 4.54) / maximo_vel_rodilla)));
                            Num_Dis_Vel_R.Minimum = disminucion_minima_rodilla;



                        }


                    }
                    else if (messagges[1] == "Rodilla")
                    {
                        string[] datos = messagges[2].Split(',');
                        PosicionR[cont_R, 0] = Convert.ToInt32(datos[0]) + 2;//+2 posicion del sensor con respecto al centro 
                        TiemposR[cont_R, 0] = Convert.ToDouble(datos[2]);
                        PosicionR[cont_R, 1] = Convert.ToInt32(datos[1]) + 2;//+2 posicion del sensor con respecto al centro 
                        TiemposR[cont_R, 1] = Convert.ToDouble(datos[3]);
                        sumatoria_min_PR = sumatoria_min_PR + PosicionR[cont_R, 1];
                        sumatoria_max_PR = sumatoria_max_PR + PosicionR[cont_R, 0];
                        sumatoria_tiempo_mMR = sumatoria_tiempo_mMR + TiemposR[cont_R, 0];
                        sumatoria_tiempo_MmR = sumatoria_tiempo_MmR + TiemposR[cont_R, 1];
                        cont_R = cont_R + 1;
                        LB_PromDesRodilla.Text = Convert.ToString(cont_R) + "/" + Convert.ToString(NRMedicion);

                        //if (cont_R == NRR)
                        if (cont_R == NRMedicion)
                        {
                            Promedio_min_PR = sumatoria_min_PR / NRMedicion; // / NRR;
                            Promedio_max_PR = sumatoria_max_PR / NRMedicion; // / NRR;
                            Promedio_MmR = sumatoria_tiempo_MmR / NRMedicion; // / NRR;
                            Promedio_mMR = sumatoria_tiempo_mMR / NRMedicion; // / NRR;

                            //Mayor a menor estirar
                            vel_prom_med_RE = (Promedio_max_PR - Promedio_min_PR) / (Promedio_MmR / 1000);
                            vel_prom_med_RF = (Promedio_max_PR - Promedio_min_PR) / (Promedio_mMR / 1000);

                            DialogResult dialogResult = MessageBox.Show("Comenzar con repeticiones de tobillo", "", MessageBoxButtons.OKCancel);

                            if (dialogResult == DialogResult.OK)
                            {
                                //Enviar repeticiones de tobillo
                                //string mensaje = "T," + NRT + "; 0,0,0,0,0,0,0;0,0,0,0,0,0,0,";
                                string mensaje = "T," + NRMedicion + "; 0,0,0,0,0,0,0;0,0,0,0,0,0,0,";

                                EnviarRasp(mensaje);

                            }
                            else if (dialogResult == DialogResult.Cancel)
                            {
                                //Cancelar repeticiones de tobillo
                                string mensaje = "X,0; 0,0,0,0,0,0,0;0,0,0,0,0,0,0,";
                                EnviarRasp(mensaje);
                            }
                        }
                    }
                    else if (messagges[1] == "Reduccion")
                    {
                        try
                        {

                            //Update Numero Repeticiones
                            ActualizarRepeticiones();


                            contador_reducciones++;



                            if (EnProcesoRodilla || EnProcesoTobillo)
                            {
                                S1.pBx_Happy.Visible = false;
                                S1.pBx_Sad.Visible = true;
                            }

                            if (EnProcesoRodilla)
                            {
                                S1.pBx_FlechaRodilla.Visible = true;
                                //Calcular nuevos limites
                                Porc_Dis_Vel_R += porc_disminucion_por_Paro;
                                Porc_Dis_Des_R += porc_disminucion_por_Paro;
                            }

                            else if (EnProcesoTobillo)
                            {
                                S1.pBx_FlechaTobillo.Visible = true;
                                //Calcular nuevos limites
                                Porc_Dis_Vel_T += porc_disminucion_por_Paro;
                                Porc_Dis_Des_T += porc_disminucion_por_Paro;
                            }

                            if (EnProcesoRodilla || EnProcesoTobillo)
                            {
                                //Calculo de nuevas velocidades y posiciones
                                Calc_Val_Reducidas();


                                //Crear nuevo Resultados Detallados en DB (reduccion actual)
                                CrearResultadosDetalles(contador_reducciones);

                                if (EnProcesoRodilla)
                                {

                                    //Cambiar posicion minima o solo desplazamiento?
                                    ConversionVelocidadesRodilla();
                                    NuevoDesplazamientoConv = NuevaPosicionMaxima - NuevaPosicionMinima;

                                    string mensaje = "X,0;" + VelocidadRodillaF + "," + VelocidadRodillaE + "," + Convert.ToString(NuevoDesplazamientoConv) + "," + Convert.ToString(NuevoDesplazamientoConv) + ",0," + NRR + ",0;0,0,0,0,0,0,0";
                                    EnviarRasp(mensaje);
                                }

                                else if (EnProcesoTobillo)
                                {
                                    ConversionVelocidadesTobillo();
                                    int angulo_min_tobillo_enviar = Convert.ToInt32(angulo_min_tobillo - 10);
                                    int angulo_max_tobillo_enviar = Convert.ToInt32(angulo_max_tobillo - 10);
                                    string mensaje = "X,0;0,0,0,0,0,0,0;" + VelocidadAngularPF + "," + VelocidadAngularDF + "," + angulo_min_tobillo_enviar + "," + angulo_max_tobillo_enviar + ",0," + NRT + ",0,";
                                    EnviarRasp(mensaje);
                                }

                                contadorRepRodillaRealizadasdis = 0;
                                contadorRepTobilloRealizadasdis = 0;

                                //cambiar etiquetas en Form4
                                fn_actualizar_etiquetas_terapia();
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }



                    }
                    else if (messagges[1] == "RepeticionesTobillo")
                    {
                        S1.Lb_repeticionestobillo.Text = messagges[2];
                        contadorRepTobilloRealizadas = Convert.ToInt32(messagges[2]);
                        contadorRepTobilloRealizadasdis++;

                        if (contadorRepTobilloRealizadas == NRT)
                        {
                            EnProcesoTobillo = false;
                            //actualizar datos de tobillo
                            ActualizarRepeticiones();

                            MessageBox.Show("La sesión ha finalizado");

                            S1.btn_finalizarsesión.Enabled = true;
                            MessageBox.Show("Retire la pierna del paciente");
                            bool bandera_pierna = true;
                            do
                            {
                                DialogResult dialogResult = MessageBox.Show("Ha retirado la pierna del paciente?", "", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {

                                    string mensaje = "X,0;0,0,0,0,0,0,1;0,0,0,0,0,0,1,";
                                    EnviarRasp(mensaje);
                                    bandera_pierna = false;
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    MessageBox.Show("Retire la pierna del paciente");
                                }
                            }
                            while (bandera_pierna == true);


                        }

                    }
                    else if (messagges[1] == "RepeticionesRodilla")
                    {
                        S1.Lb_repeticionesrodilla.Text = messagges[2];
                        contadorRepRodillaRealizadas = Convert.ToInt32(messagges[2]);
                        contadorRepRodillaRealizadasdis++;
                        if (contadorRepRodillaRealizadas == NRR)
                        {
                            EnProcesoRodilla = false;

                            //actualizar datos de rodilla
                            ActualizarRepeticiones();




                        }

                    }

                    else if (messagges[1] == "En posicion Rodilla")
                    {
                        bool bandera = false;
                        MessageBox.Show("Coloque y asegure la pierna del paciente");
                        do
                        {

                            DialogResult dialogResult = MessageBox.Show("Ha colocado la pierna del paciente?", "", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {

                                string mensaje = "X,0;" + VelocidadRodillaF + "," + VelocidadRodillaE + "," + Convert.ToString(NuevoDesplazamientoConv) + "," + Convert.ToString(NuevoDesplazamientoConv) + ",0," + NRR + ",0;0,0,0,0,0,0,0,";
                                EnviarRasp(mensaje);
                                bandera = true;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Coloque y asegure la pierna del paciente");
                            }
                        } while (bandera == false);
                    }
                    else if (messagges[1] == "En posicion Tobillo")
                    {
                        DialogResult dialogResult = MessageBox.Show("Comenzar con repeticiones de tobillo?", "", MessageBoxButtons.OKCancel);

                        if (dialogResult == DialogResult.OK)
                        {
                            EnProcesoTobillo = true;
                            ConversionVelocidadesTobillo();
                            int angulo_min_tobillo_enviar = Convert.ToInt32(angulo_min_tobillo - 10);
                            int angulo_max_tobillo_enviar = Convert.ToInt32(angulo_max_tobillo - 10);
                            string mensaje = "X,0;0,0,0,0,0,0,0;" + VelocidadAngularPF + "," + VelocidadAngularDF + "," + angulo_min_tobillo_enviar + "," + angulo_max_tobillo_enviar + ",0," + NRT + ",0,";
                            EnviarRasp(mensaje);

                        }
                        else if (dialogResult == DialogResult.Cancel)
                        {
                            EnProcesoTobillo = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Received Text: " + messagges[1]);
                        //MessageBox.Show("Received Text: " +text);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            try
            {
                current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
            }
            catch (Exception)
            {
                MessageBox.Show("El dispositivo esta desconectado");
            }
        }

        private void EnviarRasp(string mensaje)
        {
            foreach (Socket client_Socket in clientSockets)
            {

                int byteCount = Encoding.ASCII.GetByteCount(mensaje); //Measures bytes required to send ASCII data
                byte[] sendData = new byte[byteCount]; //Prepares variable size for required data
                sendData = Encoding.ASCII.GetBytes(mensaje); //Sets the sendData variable to the actual binary dat
                client_Socket.Send(sendData);
            }
        }
    }
}
}

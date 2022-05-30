using MoveLegRef.Bussines;
using MoveLegRef.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoveLegRef.Forms
{
    public partial class GenerarSesion : Form
    {
        //Por implementar conexion con hardware
        private ISocketService _socketService;


        //Por motivos de prueba se crean variables para poder anadir registros harcodeados
        //a las tablas simulando la retribucion de datos de el dispositivo de terapia


        private IPacienteService _pacienteService;
        private ISesionService _sesionService;
        private IResultadosSesion _resultadosService;

        private Paciente _pacienteSeleccionado = new Paciente();
        private Sesion _nuevaSesion = new Sesion();
        private Resultados _hardcodedResultados = new Resultados();


        private ServiceResponse<List<Paciente>> _pacientesResponse;
        private ServiceResponse<int> _sesionResponse;
        private ServiceResponse<int> _resultadosResponese;

        public GenerarSesion()
        {
            InitializeComponent();
        }
        private void GenerarSesion_Load(object sender, EventArgs e)
        {
            _pacienteService = new PacienteService();
            _pacientesResponse = new ServiceResponse<List<Paciente>>();

            _pacientesResponse = _pacienteService.ObtenerListaDePacientes();
            cbSeleccPaciente.DataSource = _pacientesResponse.Data;

            cbSeleccPaciente.DisplayMember = "Nombre";
            cbSeleccPaciente.ValueMember = "IDPaciente";

        }
        private void btnAyudaDisGuia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dispositivo guia es donde coloca la pierna NO afectada");
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            //socketService.ReceiveCallback();
        }

        private void btnAyudaPorcDism_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estos valores son el porcentaje en que se vera reducidos los angulos de flexion de la pierna a recibir terapia");
        }

        private void cbSeleccPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pacienteSeleccionado = cbSeleccPaciente.SelectedItem as Paciente;
            lblValorPiernaAfectada.Text = _pacienteSeleccionado.PiernaAfectada;
        }

        private void btnIniciarTerapia_Click(object sender, EventArgs e)
        {
            RellenarInformacion();
        }
        private void RellenarInformacion()
        {
            _nuevaSesion.RepeticionesTobillo = Convert.ToInt32(nudRepTobillo.Value);
            _nuevaSesion.RepeticionesRodilla = Convert.ToInt32(nudRepRodilla.Value);

            _nuevaSesion.PorcDismVelTobillo = Convert.ToInt32(nudPorcDisVelTob.Value);
            _nuevaSesion.PorcDismVelRodilla = Convert.ToInt32(nudPorcDisVelRod.Value);
            _nuevaSesion.PorcDismMovTobillo = Convert.ToInt32(nudPorcDisMovTob.Value);
            _nuevaSesion.PorcDismDespRodilla = Convert.ToInt32(nudPorcDisDespRod.Value);

            _nuevaSesion.VelTobilloDisminuido = 12.1f;
            _nuevaSesion.VelRodillaDisminuido = 12.1f;
            _nuevaSesion.MovTobilloDisminuido = 12.1f;
            _nuevaSesion.DespRodillaDisminuido = 12.1f;
        }

        private void btnGenerarSesionEST_Click(object sender, EventArgs e)
        {
            //Este es mi metodo de prueba para agregar una sesion nueva a cada paciente

            _sesionService = new SesionService();
            _sesionResponse = new ServiceResponse<int>();

            _resultadosService = new ResultadosService();
            _resultadosResponese = new ServiceResponse<int>();

            _nuevaSesion.IDPaciente = _pacienteSeleccionado.IDPaciente;

            _nuevaSesion.RepeticionesTobillo = 99;
            _nuevaSesion.RepeticionesRodilla = 99;

            _nuevaSesion.PorcDismVelTobillo = 33;
            _nuevaSesion.PorcDismVelRodilla = 33;
            _nuevaSesion.PorcDismMovTobillo = 33;
            _nuevaSesion.PorcDismDespRodilla = 33;

            _nuevaSesion.VelTobilloDisminuido = 12.1f;
            _nuevaSesion.VelRodillaDisminuido = 12.1f;
            _nuevaSesion.MovTobilloDisminuido = 12.1f;
            _nuevaSesion.DespRodillaDisminuido = 12.1f;

            //El consumo de el servicio de agregado de sesiones queda listo para el paciente n
            _sesionResponse = _sesionService.AgregarSesion(_nuevaSesion);

            _hardcodedResultados.IDSesion = _sesionResponse.Data;
            _hardcodedResultados.TiempoTranscurrido = 111;
            _hardcodedResultados.RepeticionesLogradasRodilla = 100;
            _hardcodedResultados.RepeticionesLogradasTobillo = 100;

            //De igual maner el consumo de este servicio funciona para la sesion n
            _resultadosResponese = _resultadosService.AgregarResultadosSesion(_hardcodedResultados);

            MessageBox.Show(_sesionResponse.Message + " y " + _resultadosResponese.Message);

            this.Close();
        }

    }
}

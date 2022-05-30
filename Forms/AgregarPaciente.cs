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
    public partial class AgregarPaciente : Form
    {
        private IPacienteService _pacienteService = new PacienteService();
        Paciente nuevoPaciente = new Paciente();
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            ServiceResponse<int> serviceResponse = new ServiceResponse<int>();

            RellenarInformacion();

            serviceResponse = _pacienteService.AgregarPaciente(nuevoPaciente);

            MessageBox.Show("Paciente Agregado");

            this.Close();
        }

        private void RellenarInformacion()
        {
            nuevoPaciente.Nombre = txtNombreAP.Text;
            nuevoPaciente.Edad = (int)nudEdadAP.Value;
            nuevoPaciente.Patologia = txtPatologiaAP.Text;
            nuevoPaciente.PiernaAfectada = cbPiernaAfectadaAP.Text;

            nuevoPaciente.AnguloCadera = (float)nudCaderaAng.Value;
            nuevoPaciente.AnguloRodilla = (float)nudRodillaAng.Value;
            nuevoPaciente.AnguloPlanta = (float)nudPlantaAng.Value;
            nuevoPaciente.AnguloDorsifexion = (float)nudDorsifexion.Value;

            nuevoPaciente.MedidaCaderaRodillaDerecha = (float)nudCadRodDer.Value;
            nuevoPaciente.MedidaRodillaTobilloDerecha = (float)nudRodTobDer.Value;
            nuevoPaciente.MedidaTobilloDedosDerecha = (float)nudTobDedDer.Value;
            nuevoPaciente.MedidaCaderaRodillaIzq = (float)nudCadRodIzq.Value;
            nuevoPaciente.MedidaRodillaTobilloIzq = (float)nudRodTobIzq.Value;
            nuevoPaciente.MedidaTobilloDedosIzq = (float)nudTodDedIzq.Value;
        }

        private void btnAyudaAng_Click(object sender, EventArgs e)
        {
            AyudaVisualAngulos ayudaVisualAngulos = new AyudaVisualAngulos();
            ayudaVisualAngulos.Show();
        }

        private void btnAyudaMed_Click(object sender, EventArgs e)
        {
            AyudaVisualMedidas ayudaVisualMedidas = new AyudaVisualMedidas();
            ayudaVisualMedidas.Show();
        }
    }
}

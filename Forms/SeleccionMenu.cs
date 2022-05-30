using MoveLegRef.Bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoveLegRef.Forms
{
    public partial class SeleccionMenu : Form
    {
        private AgregarPaciente _AgregarPaciente;
        private GenerarSesion _GenerarSesion;
        private SesionTerapia _SesionTerapia;
        private ConsultaPaciente _ConsultaPaciente;

        public SeleccionMenu()
        {
            InitializeComponent();
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            _AgregarPaciente = new AgregarPaciente();
            _AgregarPaciente.FormClosed += (s, args) => this.Show();

            _AgregarPaciente.Show();
            this.Hide();
        }

        private void btnNuevaSesion_Click(object sender, EventArgs e)
        {
            _GenerarSesion = new GenerarSesion();
            _GenerarSesion.FormClosed += (s, args) => this.Show();

            _GenerarSesion.Show();
            this.Hide();

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            _SesionTerapia = new SesionTerapia();
            _SesionTerapia.FormClosed += (s, args) => this.Show();

            _SesionTerapia.Show();
            this.Hide();
        }

        private void btnListadoPacientes_Click(object sender, EventArgs e)
        {
            _ConsultaPaciente = new ConsultaPaciente();
            _ConsultaPaciente.FormClosed += (s, args) => this.Show();

            _ConsultaPaciente.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionMenu_Load(object sender, EventArgs e)
        {
        }
    }
}

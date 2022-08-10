using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoveLegRef.Forms
{
    public partial class SesionTerapia : Form
    {
        internal int segundos = 0, minutos = 0, horas = 0;
        public SesionTerapia()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            //AQUI SE AGREGA A BASE DE DATOS PROBABLEMENTE
        }

        private void tmrTiempoTerapia_Tick(object sender, EventArgs e)
        {
            segundos ++;

            if (segundos == 60)
            {
                minutos++;
                segundos = 0;
            }
            if (minutos == 60)
            {
                horas++;
                minutos = 0;
            }

            lblSesionET.Text = horas.ToString("D2") + ":" + minutos.ToString("D2") + ":" + segundos.ToString("D2");
        }
    }
}

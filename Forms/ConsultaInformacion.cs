using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MoveLegRef.Bussines;
using MoveLegRef.Models;
using IronPdf;

namespace MoveLegRef.Forms
{
    public partial class ConsultaPaciente : Form
    {
        private IPacienteService _pacienteService;
        private ISesionService _sesionService;
        private IResultadosSesion _resultadosService;

        private ServiceResponse<List<Paciente>> _pacientesResponse = new ServiceResponse<List<Paciente>>();
        private ServiceResponse<List<Sesion>> _sesionesResponse = new ServiceResponse<List<Sesion>>();
        private ServiceResponse<List<Resultados>> _resultadosResponse = new ServiceResponse<List<Resultados>>();

        public ConsultaPaciente()
        {
            InitializeComponent();
            _pacienteService = new PacienteService();
            _sesionService = new SesionService();
            _resultadosService = new ResultadosService();
        }
        private void ConsultaPaciente_Load(object sender, EventArgs e)
        {
            _pacientesResponse = _pacienteService.ObtenerListaDePacientes();

            cbSeleccPaciente.DataSource = _pacientesResponse.Data;

            cbSeleccPaciente.DisplayMember = "Nombre";
            cbSeleccPaciente.ValueMember = "IDPaciente";

            dgvSesiones.Columns["IDPaciente"].Visible = false;
            dgvSesiones.Columns["IDSesion"].Visible = false;
        }
        private void cbSeleccPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paciente = cbSeleccPaciente.SelectedItem as Paciente;
            int idPaciente = paciente.IDPaciente;

            lblTTSValor.Text = "...";
            lblRepLogRodVal.Text = "...";
            lblRepLogTobVal.Text = "...";

            _sesionesResponse = _sesionService.ObtenerListaDeSesiones(idPaciente);
            dgvSesiones.DataSource = _sesionesResponse.Data;
        }
        private void btnAyudaListado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui puedes seleccionar un pacente para conocer sus detalles");
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSesiones.SelectedRows[0];
                var selectedSesionID = Convert.ToInt32(selectedRow.Cells["IDSesion"].Value);

                //Siempre busca el IDSesion numero 4 (dentro de servicio) para que siempre encuentr una sesion, ergo, un resultado
                //gracias al metodo de prueba fijo

                _resultadosResponse = _resultadosService.ObtenerResultados(selectedSesionID);

                lblTTSValor.Text = _resultadosResponse.Data[0].TiempoTranscurrido.ToString();
                lblRepLogRodVal.Text = _resultadosResponse.Data[0].RepeticionesLogradasRodilla.ToString();
                lblRepLogTobVal.Text = _resultadosResponse.Data[0].RepeticionesLogradasTobillo.ToString();

            }
            else
            {
                MessageBox.Show("No se encontro contenido");
            }
        }

        private void btnDetalleResultados_Click(object sender, EventArgs e)
        {
            HistogramaResultados histogramaResultados = new HistogramaResultados();
            if (_resultadosResponse.IsOk && _resultadosResponse.Data.Count !=0)
            {
                histogramaResultados = new HistogramaResultados(_resultadosResponse.Data[0]);
                histogramaResultados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cargue resultados primero");
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {

            if (_resultadosResponse.IsOk && _resultadosResponse.Data.Count != 0)
            {
                string pdfstring = BuildPDFString();

                var Renderer = new IronPdf.ChromePdfRenderer();
                using var pdf = Renderer.RenderHtmlAsPdf(pdfstring);

                try
                {
                    pdf.SaveAs("C:/Users/PC/Desktop/Reporte-de-Paciente.pdf");
                    MessageBox.Show("Reporte creado con exito");
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salio mal");
                }
            }
            else
            {
                MessageBox.Show("Cargue resultados primero");
            }
        }
        internal string BuildPDFString()
        {
            var paciente = cbSeleccPaciente.SelectedItem as Paciente;
            var sesiones = _sesionesResponse.Data;
            var resultados = _resultadosResponse.Data;

            string pdfString = "REPORTE POR PACIENTE<br><br>Nombre: " + paciente.Nombre + "<br>Edad: " + paciente.Edad +
                                "<br>Patologia: " + paciente.Patologia + "<br>Pierna afectada: "
                                + paciente.PiernaAfectada + "<br><br>SESIONES<br>";
            foreach (var item in sesiones)
            {
                pdfString += "<br>Repeticiones deseadas (rodilla): " + item.RepeticionesRodilla.ToString() +
                            "<br>Repeticiones deseadas (tobillo): " + item.RepeticionesTobillo.ToString();
            }

            pdfString += "<br><br>RESULTADOS CORRESPONDIENTES <br><br>";

            foreach (var item in resultados)
            {
                pdfString += "Repeticiones logradas rodilla: " + item.RepeticionesLogradasRodilla.ToString() +
                             "<br>Repeticiones logradas tobillo: " + item.RepeticionesLogradasTobillo.ToString() +
                             "<br>Tiempor transcurrido: " + item.TiempoTranscurrido.ToString() + "<br>";
            }

            return pdfString;
        }
    }
}

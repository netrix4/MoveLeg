using MoveLegRef.Bussines;
using MoveLegRef.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MoveLegRef.Forms
{
    public partial class CompararResultados : Form
    {
        private IPacienteService _pacienteService;
        private IResultadosSesion _resultadosService;

        private ServiceResponse<List<Paciente>> _pacientesResponse = new ServiceResponse<List<Paciente>>();
        private ServiceResponse<List<Resultados>> _resultadosResponse = new ServiceResponse<List<Resultados>>();

        public CompararResultados()
        {
            InitializeComponent();
            _pacienteService = new PacienteService();
            _resultadosService = new ResultadosService();
        }
        private void CompararResultados_Load(object sender, EventArgs e)
        {
            _pacientesResponse = _pacienteService.ObtenerListaDePacientes();
            cbSeleccPaciente.DataSource = _pacientesResponse.Data;

            cbSeleccPaciente.DisplayMember = "Nombre";
            cbSeleccPaciente.ValueMember = "IDPaciente";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSeleccPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paciente = cbSeleccPaciente.SelectedItem as Paciente;
            int idPaciente = paciente.IDPaciente;

            _resultadosResponse = _resultadosService.ObtenerResultadosPorPaciente(idPaciente);
            SetChartData(_resultadosResponse.Data);
        }
        internal void SetChartData(List<Resultados> chartDataResultados)
        {
            PlotModel chartPlotModel = new PlotModel();

            chartPlotModel.Title = "Histograma de Resultados de Repeticiones";
            foreach (var item in chartDataResultados)
            {
                var barSeries = new BarSeries
                {
                    ItemsSource = new List<BarItem>(new[]
                     {
                        new BarItem { Value = Convert.ToDouble(item.RepeticionesLogradasRodilla) },
                        new BarItem { Value = Convert.ToDouble(item.RepeticionesLogradasTobillo) },
                    }),

                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0}"
                };

                chartPlotModel.Series.Add(barSeries);
            }

            chartPlotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "EjeCamposResultados",
                ItemsSource = new[]
                {
                    "Repeticiones Logradas Rodilla",
                    "Repeticiones Logradas Tobillo",
                }
            });
            pvContenido.Model = chartPlotModel;
        }
    }
}

using MoveLegRef.Bussines;
using MoveLegRef.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;
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
            int counter = 0;
            PlotModel chartPlotModel = new PlotModel();
            Legend legend = new Legend();

            chartPlotModel.Legends.Add(legend);
            chartPlotModel.Title = "Progreso de resultado de paciente";
            chartPlotModel.Subtitle = "Resultados por sesion";

            LineSeries lineSeriesRepRodilla = new LineSeries { Title = "Repeticiones Rodilla", MarkerType = MarkerType.Triangle };
            LineSeries lineSeriesRepTobillo = new LineSeries { Title = "Repeticiones Tobillo", MarkerType = MarkerType.Diamond, };

            lineSeriesRepRodilla.Points.Add(new DataPoint(0,0));
            lineSeriesRepTobillo.Points.Add(new DataPoint(0,0));

            foreach (var item in chartDataResultados)
            {

                lineSeriesRepRodilla.Points.Add(new DataPoint(counter + 1, item.RepeticionesLogradasRodilla));
                lineSeriesRepTobillo.Points.Add(new DataPoint(counter + 1, item.RepeticionesLogradasTobillo));

                counter++;
            }

            counter = 0;

            chartPlotModel.Series.Add(lineSeriesRepRodilla);
            chartPlotModel.Series.Add(lineSeriesRepTobillo);

            pvContenido.Model = chartPlotModel;
        }
    }
}

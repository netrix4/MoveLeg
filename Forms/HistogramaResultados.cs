using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MoveLegRef.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace MoveLegRef.Forms
{
    public partial class HistogramaResultados : Form
    {
        // create a model and add the bars into it
        private PlotModel _ChartPlotModel = new PlotModel();

        public HistogramaResultados()
        {
            InitializeComponent();

            _ChartPlotModel.Title = "Cake Type Popularity (Deafault Constructor)";

            //generate a random percentage distribution between the 5
            //cake-types (see axis below)
            var rand = new Random();
            double[] cakePopularity = new double[5];
            for (int i = 0; i < 5; ++i)
            {
                cakePopularity[i] = rand.NextDouble();
            }

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                 {
                    new BarItem{ Value = cakePopularity[0]},
                    new BarItem{ Value = cakePopularity[1]},
                    new BarItem{ Value = cakePopularity[2]},
                    new BarItem{ Value = cakePopularity[3]},
                    new BarItem{ Value = cakePopularity[4]}
                }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}%"
            };
            _ChartPlotModel.Series.Add(barSeries);

            _ChartPlotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CakeAxis",
                ItemsSource = new[]
                {
                    "Apple cake",
                    "Baumkuchen",
                    "Bundt Cake",
                    "Chocolate cake",
                    "Carrot cake"
                }
            });
            pvHistograma.Model = _ChartPlotModel;
        }
        public HistogramaResultados(Sesion sesion)
        {
            // sesion.RepeticionesRodilla;
            // sesion.RepeticionesTobillo;

        }
        public HistogramaResultados(Resultados resultados)
        {
            InitializeComponent();
            //Todo Agregar ek nombre de pacente
            _ChartPlotModel.Title = "Histograma de Resultados de Repeticiones";

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                 {
                    //LinearBarSeries
                    new BarItem { Value = Convert.ToDouble(resultados.RepeticionesLogradasRodilla) },
                    new BarItem { Value = Convert.ToDouble(resultados.RepeticionesLogradasTobillo) },
                }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}"
            };
            _ChartPlotModel.Series.Add(barSeries);

            _ChartPlotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "EjeCamposResultados",
                ItemsSource = new[]
                {
                    "Repeticiones Logradas Rodilla",
                    "Repeticiones Logradas Tobillo",
                }
            });
            pvHistograma.Model = _ChartPlotModel;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

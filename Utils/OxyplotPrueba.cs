using System;
using System.Collections.Generic;
using System.Text;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace MoveLegRef.Utils
{
    class OxyplotPrueba
    {
        private void ChartsPrueba_Load(object sender, EventArgs e)
        {
            // generate some random Y data
            int pointCount = 5;
            double[] ys1 = { 1, 7, 3, 4, 5 };
            double[] ys2 = { 1, 2, 7, 4, 7 };

            // create a series of bars and populate them with data

            LinearBarSeries seriesA = new LinearBarSeries()
            {
                Title = "Series A",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.Red,
                BarWidth = 15,
            };

            LinearBarSeries seriesB = new LinearBarSeries()
            {
                Title = "Series B",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.Blue,
                BarWidth = 10,

            };

            for (int i = 0; i < pointCount; i++)
            {
                seriesA.Points.Add(new DataPoint(i, ys1[i]));
                seriesB.Points.Add(new DataPoint(i, ys2[i]));
            }

            // create a model and add the bars into it
            var model = new PlotModel
            {
                Title = "Bar Graph (Column Series)"
            };
            var Xaxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                MaximumDataMargin = 2
            };
            model.Axes.Add(Xaxis);

            model.Series.Add(seriesA);
            model.Series.Add(seriesB);

            // load the model into the user control
            plotView1.Model = model;


        }
    }
}

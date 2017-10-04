using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YazLab1
{
    public partial class Histogram : Form
    {
        private Series redSeries;
        private Series greenSeries;
        private Series blueSeries;

        public Histogram()
        {
            InitializeComponent();

            //DrawChart();
        }
        private void DrawChart()
        {
            var histogramData = ImageEdit.Histogram();

            chartHistogram.ChartAreas[0].AxisY.ScaleView.Zoom(0, histogramData.Item2 * 4);
            chartHistogram.ChartAreas[0].AxisX.ScaleView.Zoom(0, 255);

            redSeries = new Series("red");
            greenSeries = new Series("green");
            blueSeries = new Series("blue");

            for (int i = 0; i < 255; i++)
            {
                redSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(0)[i]);
                greenSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(1)[i]);
                blueSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(2)[i]);
            }
        }
        private void cboxRed_CheckedChanged(object sender, EventArgs e)
        {
            if (chartHistogram.Series.Contains(redSeries))
            {
                chartHistogram.Series.Remove(redSeries);
            }
            else
            {
                chartHistogram.Series.Add(redSeries);

                chartHistogram.Series["red"].Color = Color.Red;
            }
        }
        private void cboxGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chartHistogram.Series.Contains(greenSeries))
            {
                chartHistogram.Series.Remove(greenSeries);
            }
            else
            {
                chartHistogram.Series.Add(greenSeries);

                chartHistogram.Series["green"].Color = Color.Green;
            }
        }
        private void cboxBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (chartHistogram.Series.Contains(blueSeries))
            {
                chartHistogram.Series.Remove(blueSeries);
            }
            else
            {
                chartHistogram.Series.Add(blueSeries);

                chartHistogram.Series["blue"].Color = Color.Blue;
            }
        }
    }
}

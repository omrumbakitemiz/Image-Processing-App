using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YazLab1
{
    public partial class Form1 : Form
    {
        private Series redSeries;
        private Series greenSeries;
        private Series blueSeries;

        public Form1()
        {
            InitializeComponent();

            var data = Histogram.ImportImage();
            
            chartHistogram.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chartHistogram.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chartHistogram.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chartHistogram.ChartAreas[0].AxisY.ScaleView.Zoom(0, 120000);
            chartHistogram.ChartAreas[0].AxisX.ScaleView.Zoom(0, 255);
            chartHistogram.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartHistogram.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartHistogram.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            redSeries = new Series("red");
            greenSeries = new Series("green");
            blueSeries = new Series("blue");

            for (int i = 0; i < 255; i++)
            {
                redSeries.Points.AddXY(i, data.ElementAt(0)[i]);
                greenSeries.Points.AddXY(i, data.ElementAt(1)[i]);
                blueSeries.Points.AddXY(i, data.ElementAt(2)[i]);
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

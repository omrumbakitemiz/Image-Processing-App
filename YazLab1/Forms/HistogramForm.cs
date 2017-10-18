using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using YazLab1.Forms;

namespace YazLab1
{
    public partial class HistogramForm : Form
    {
        private Series redSeries;
        private Series greenSeries;
        private Series blueSeries;
        private Series grayscaleSeries;
        private Image image;

        public HistogramForm()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPageForm.SelectedImage;

            CalculateChart();

        }

        public HistogramForm(Image image)
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            this.image = image;
            
            CalculateChart();
        }
        private void CalculateChart()
        {
            var histogramData = ImageEdit.Histogram(image);

            chartHistogram.ChartAreas[0].AxisY.ScaleView.Zoom(0, histogramData.Item2 * 4);
            chartHistogram.ChartAreas[0].AxisX.ScaleView.Zoom(0, 255);

            redSeries = new Series("red");
            greenSeries = new Series("green");
            blueSeries = new Series("blue");
            grayscaleSeries = new Series("grayscale");

            for (int i = 0; i < 255; i++)
            {
                redSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(0)[i]);
                greenSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(1)[i]);
                blueSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(2)[i]);
                grayscaleSeries.Points.AddXY(i, histogramData.histogramValues.ElementAt(3)[i]);
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

                chartHistogram.Series["red"].ChartType = SeriesChartType.Column;
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

                chartHistogram.Series["green"].ChartType = SeriesChartType.Column;
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

                chartHistogram.Series["blue"].ChartType = SeriesChartType.Column;
                chartHistogram.Series["blue"].Color = Color.Blue;
            }
        }
        private void cboxGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            if (chartHistogram.Series.Contains(grayscaleSeries))
            {
                chartHistogram.Series.Remove(grayscaleSeries);
            }
            else
            {
                chartHistogram.Series.Add(grayscaleSeries);

                chartHistogram.Series["grayscale"].ChartType = SeriesChartType.Column;
                chartHistogram.Series["grayscale"].Color = Color.DarkGray;
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            var imageEditForm = new ImageEditForm();

            Hide();

            imageEditForm.Show();
        }
    }
}

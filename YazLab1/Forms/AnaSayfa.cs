using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YazLab1
{
    public partial class AnaSayfa : Form
    {

        public AnaSayfa()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized; 
            #endregion
        }
        
        private static void Negative()
        {
            var image = Image.FromFile(@"C://image7.jpg");
            var newImage = ImageEdit.Negative(image);
        }
        private void btn_Mirror_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageEdit.Mirror(pictureBox1.Image);
        }

        private void btn_fileOpen_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = OpenFile();
        }
        
        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageEdit.Grayscale(pictureBox1.Image);
        }
        private Image OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            Image image = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
            }

            return image;
        }

        private void btn_colorChannels_Click(object sender, EventArgs e)
        {
            var colorChannelsForm = new ColorChannels();

            Hide();

            colorChannelsForm.Show();
        }
    }
}

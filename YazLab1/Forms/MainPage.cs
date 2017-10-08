using System;
using System.Drawing;
using System.Windows.Forms;
using YazLab1.Forms;

namespace YazLab1
{
    public partial class MainPage : Form
    {
        public static Image selectedImage { get; set; }
        
        public MainPage()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion
        }

        private void btn_fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                selectedImage = Image.FromFile(openFileDialog.FileName);
                pictureBox.Image = selectedImage;

                lbl_message.Text = "Please select an action";
                lbl_message.ForeColor = Color.Red;
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_histogram_Click(object sender, EventArgs e)
        {
            var histogramForm = new Histogram();

            Hide();

            histogramForm.Show();
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            var negativeForm = new Negative();

            Hide();

            negativeForm.Show();
        }

        private void btn_mirror_Click(object sender, EventArgs e)
        {
            var mirrorForm = new Mirror();

            Hide();

            mirrorForm.Show();
        }

        private void btn_colorChannels_Click(object sender, EventArgs e)
        {
            var colorChannelsForm = new ColorChannels();

            Hide();

            colorChannelsForm.Show();
        }

        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            var grayscaleForm = new Grayscale();

            Hide();

            grayscaleForm.Show();
        }
    }
}

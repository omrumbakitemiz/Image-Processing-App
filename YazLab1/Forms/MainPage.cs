using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazLab1.Forms;

namespace YazLab1
{
    public partial class MainPage : Form
    {
        public static Image selectedImage { get; set; }
        private string FileName;
        
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
                FileName = openFileDialog.FileName;

                selectedImage = Image.FromFile(FileName);
                pictureBox.Image = selectedImage;

                lbl_message.Text = "Please select an action";
                lbl_message.ForeColor = Color.Red;

                #region Image Information
                var imageWidth = selectedImage.Width;
                var imageHeight = selectedImage.Height;
                var imagePixelSum = imageWidth * imageHeight;

                #region İşlem Zaman Tahmini
                var estimatedProcessTime = "Unknown";

                if (imagePixelSum > 1000000) //One million
                {
                    estimatedProcessTime = "High";
                }
                else
                {
                    estimatedProcessTime = "Low";
                }
                #endregion

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append($"Width: {imageWidth}, Height: {imageHeight}, Estimated Process Time:");
                lbl_estimatedProcessTime.Text = $"{estimatedProcessTime}";
                if (lbl_estimatedProcessTime.Text == "High")
                {
                    lbl_estimatedProcessTime.ForeColor = Color.Red;
                    lbl_estimatedProcessTime.Font = new Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold);
                }
                else
                {
                    lbl_estimatedProcessTime.ForeColor = Color.Green;
                    lbl_estimatedProcessTime.Font = new Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Regular);
                }
                lbl_info.Text = stringBuilder.ToString();
                #endregion
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

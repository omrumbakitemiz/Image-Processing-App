using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazLab1.Forms;

namespace YazLab1
{
    public partial class MainPageForm : Form
    {
        public static Image SelectedImage { get; set; }
        private string FileName;
        
        public MainPageForm()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion
        }
       
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.ico) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png, *.ico";
            openFileDialog.Title = "Lütfen bir resim dosyası seçin";

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;

                SelectedImage = Image.FromFile(FileName);
                pictureBox.Image = SelectedImage;

                lbl_message.ForeColor = Color.Red;

                #region Image Information
                var imageWidth = SelectedImage.Width;
                var imageHeight = SelectedImage.Height;
                var imagePixelSum = imageWidth * imageHeight;

                #region İşlem Zaman Tahmini
                var estimatedProcessTime = "Bilinmiyor";

                if (imagePixelSum > 1000000) //One million
                {
                    estimatedProcessTime = "Yüksek";
                }
                else
                {
                    estimatedProcessTime = "Düşük";
                }
                #endregion

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append($"Genişlik: {imageWidth}, Yükşeklik: {imageHeight}, Tahmini işlem süresi:");
                lbl_estimatedProcessTime.Text = $"{estimatedProcessTime}";
                if (lbl_estimatedProcessTime.Text == "Yüksek")
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
                MessageBox.Show("Lütfen resim seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Click Events

        private void btn_fileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Uygulamayı kapatmak istediğinizden emin misiniz?", "Dikkat", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void OpenImageEditForm(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                MessageBox.Show("Lütfen resim seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var imageEditForm = new ImageEditForm();

                Hide();

                imageEditForm.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        #endregion
    }
}

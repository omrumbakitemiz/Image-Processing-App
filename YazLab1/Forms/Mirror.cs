using System;
using System.Drawing;
using System.Windows.Forms;

namespace YazLab1.Forms
{
    public partial class Mirror : Form
    {
        private Image image;
        public Mirror()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPage.selectedImage;

            pictureBox1.Image = image;
        }

        private void btn_mirror_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ImageEdit.Mirror(image);
        }
    }
}

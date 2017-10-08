using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1
{
    public partial class Negative : Form
    {
        private Image image;
        public Negative()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPage.selectedImage;
            pictureBox.Image = image;
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            pictureBox.Image = ImageEdit.Negative(image);
        }
    }
}

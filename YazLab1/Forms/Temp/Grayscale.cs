using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1.Forms
{
    public partial class Grayscale : Form
    {
        private Image image;
        public Grayscale()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPageForm.SelectedImage;
            pbox_normal.Image = image;
        }

        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            pbox_grayscale.Image = ImageEdit.Grayscale(image);
        }
    }
}

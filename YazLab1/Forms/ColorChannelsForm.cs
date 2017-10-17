using System;
using System.Drawing;
using System.Windows.Forms;
using YazLab1.Forms;

namespace YazLab1
{
    public partial class ColorChannelsForm : Form
    {
        public ColorChannelsForm()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion
        }

        public ColorChannelsForm(Image image)
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            pbox_mainImage.Image = image;
        }

        private void btn_colorChannels_Click(object sender, EventArgs e)
        {
            var colorChannelList = ImageEdit.ColorChannels(pbox_mainImage.Image);

            pbox_redColorChannel.Image = colorChannelList[0];
            pbox_greenColorChannel.Image = colorChannelList[1];
            pbox_blueColorChannel.Image = colorChannelList[2];
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var imageEditForm = new ImageEditForm(pbox_mainImage.Image);

            Hide();

            imageEditForm.Show();
        }
    }
}

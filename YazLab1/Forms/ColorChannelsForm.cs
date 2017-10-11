using System.Drawing;
using System.Windows.Forms;

namespace YazLab1
{
    public partial class ColorChannelsForm : Form
    {
        private Image image;
        public ColorChannelsForm()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPageForm.SelectedImage;

            pbox_mainImage.Image = image;
        }

        private void btn_colorChannels_Click(object sender, System.EventArgs e)
        {
            var colorChannelList = ImageEdit.ColorChannels(image);

            pbox_redColorChannel.Image = colorChannelList[0];
            pbox_greenColorChannel.Image = colorChannelList[1];
            pbox_blueColorChannel.Image = colorChannelList[2];
        }
    }
}

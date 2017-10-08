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
    public partial class ColorChannels : Form
    {
        public ColorChannels()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            var image = Image.FromFile(@"C://image5.jpg");

            var colorChannelList = ImageEdit.ColorChannels(image);

            redColorChannel.Image = colorChannelList[0];
            greenColorChannel.Image = colorChannelList[1];
            blueColorChannel.Image = colorChannelList[2];
        }
    }
}

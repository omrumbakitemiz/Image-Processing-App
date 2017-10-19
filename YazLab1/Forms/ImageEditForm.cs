using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace YazLab1.Forms
{
    public partial class ImageEditForm : Form
    {
        private Image originalImage = MainPageForm.SelectedImage;
        private bool firstChoise = false;
        public ImageEditForm()
        {
            InitializeComponent();
            
            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            pbox_original.Image = MainPageForm.SelectedImage;
            pbox_edited.Image = ImageEdit.editedImage;
            ImageEdit.originalImage = MainPageForm.SelectedImage;
        }

        public ImageEditForm(Image image)
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            pbox_original.Image = image;
        }

        #region Click Events
        private void btn_grayscale_Click(object sender, EventArgs e)
        {
            if (!firstChoise)
            {
                pbox_edited.Image = pbox_original.Image;

                firstChoise = true;
            }
            
            ImageEdit.imageStack.Push(pbox_edited.Image);
            ImageEdit.editedImage = pbox_edited.Image;
            pbox_edited.Image = ImageEdit.Grayscale(pbox_edited.Image);
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            if (!firstChoise)
            {
                pbox_edited.Image = pbox_original.Image;

                firstChoise = true;
            }
            
            ImageEdit.imageStack.Push(pbox_edited.Image);
            ImageEdit.editedImage = pbox_edited.Image;
            pbox_edited.Image = ImageEdit.Rotate(pbox_edited.Image);
        }

        private void btn_mirror_Click(object sender, EventArgs e)
        {
            if (!firstChoise)
            {
                pbox_edited.Image = pbox_original.Image;

                firstChoise = true;
            }
            
            ImageEdit.imageStack.Push(pbox_edited.Image);
            ImageEdit.editedImage = pbox_edited.Image;
            pbox_edited.Image = ImageEdit.Mirror(pbox_edited.Image);
        }

        private void btn_scale_Click(object sender, EventArgs e)
        {
            try
            {
                var scaleRate = Convert.ToDouble(txb_scaleRate.Text);

                if (!firstChoise)
                {
                    pbox_edited.Image = pbox_original.Image;

                    firstChoise = true;
                }
                
                ImageEdit.imageStack.Push(pbox_edited.Image);
                ImageEdit.editedImage = pbox_edited.Image;

                pbox_edited.Image = ImageEdit.Scale(pbox_edited.Image, scaleRate);
                pbox_edited.SizeMode = PictureBoxSizeMode.CenterImage;
                pbox_original.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_negative_Click(object sender, EventArgs e)
        {
            if (!firstChoise)
            {
                pbox_edited.Image = pbox_original.Image;

                firstChoise = true;
            }
            
            ImageEdit.imageStack.Push(pbox_edited.Image);
            ImageEdit.editedImage = pbox_edited.Image;
            pbox_edited.Image = ImageEdit.Negative(pbox_edited.Image);
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (ImageEdit.imageStack.Count == 0)
            {
                MessageBox.Show("Daha fazla geri alamazsınız!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pbox_edited.Image = ImageEdit.imageStack.Pop();
            }
        }

        private void btn_backtoMainPage_Click(object sender, EventArgs e)
        {
            var mainPageForm = new MainPageForm();

            Hide();
            mainPageForm.Show();
        }

        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainPageForm = new MainPageForm();

            Hide();
            mainPageForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Save an Image File",
                    Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"
                };

                var fileDialog = saveFileDialog.ShowDialog();

                if (fileDialog == DialogResult.OK)
                {
                    if (pbox_edited.Image == null)
                    {
                        pbox_original.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    }
                    else
                    {
                        pbox_edited.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    }
                }
                else if (fileDialog == DialogResult.Cancel)
                {
                    MessageBox.Show("Lütfen kayıt yeri seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Dosya kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbox_original.Image = originalImage;
            pbox_edited.Image = originalImage;
        }

        private void toolStripMenuItem_histogram_Click(object sender, EventArgs e)
        {
            if (pbox_edited.Image == null)
            {
                var histogramForm = new HistogramForm(pbox_original.Image);

                Hide();

                histogramForm.Show();
            }
            else
            {
                var histogramForm = new HistogramForm(pbox_edited.Image);

                Hide();

                histogramForm.Show();
            }
        }

        private void toolStripMenuItem_colorChannel_Click(object sender, EventArgs e)
        {
            if (pbox_edited.Image == null)
            {
                var colorChannelsForm = new ColorChannelsForm(pbox_original.Image);

                Hide();

                colorChannelsForm.Show();
            }
            else
            {
                var colorChannelsForm = new ColorChannelsForm(pbox_edited.Image);

                Hide();

                colorChannelsForm.Show();
            }
        }

        #endregion
    }
}

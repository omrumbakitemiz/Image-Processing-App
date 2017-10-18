using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace YazLab1.Forms
{
    public partial class ImageEditForm : Form
    {
        private Image originalImage = MainPageForm.SelectedImage;
        private Stack<Image> imageStack = new Stack<Image>();
        private bool firstChoise = false;
        public ImageEditForm()
        {
            InitializeComponent();
            
            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            pbox_original.Image = MainPageForm.SelectedImage;
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

            imageStack.Push(pbox_edited.Image);
            pbox_edited.Image = ImageEdit.Grayscale(pbox_edited.Image);
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            if (!firstChoise)
            {
                pbox_edited.Image = pbox_original.Image;

                firstChoise = true;
            }

            imageStack.Push(pbox_edited.Image);
            pbox_edited.Image = ImageEdit.Rotate(pbox_edited.Image);
        }

        private void btn_mirror_Click(object sender, EventArgs e)
        {
            if (!firstChoise)
            {
                pbox_edited.Image = pbox_original.Image;

                firstChoise = true;
            }

            imageStack.Push(pbox_edited.Image);
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

                imageStack.Push(pbox_edited.Image);

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

            imageStack.Push(pbox_edited.Image);
            pbox_edited.Image = ImageEdit.Negative(pbox_edited.Image);
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (imageStack.Count == 0)
            {
                MessageBox.Show("You cannot undo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pbox_edited.Image = imageStack.Pop();
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
            var dialogResult = MessageBox.Show("Application will be closed, Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem_suprise_Click(object sender, EventArgs e)
        {
            //Suprise();
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
                    MessageBox.Show("Please select save location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("File saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < imageStack.Count - 1; i++)
            //{
            //    imageStack.Pop();
            //}
            //pbox_edited.Image = imageStack.Peek();

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

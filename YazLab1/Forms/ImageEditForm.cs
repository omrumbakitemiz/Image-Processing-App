using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YazLab1.Forms
{
    public partial class ImageEditForm : Form
    {
        private Stack<Image> imageStack = new Stack<Image>();
        private Image image;
        private bool firstChoise = false;
        public ImageEditForm()
        {
            InitializeComponent();
            
            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPageForm.SelectedImage;
            pbox_original.Image = image;
        }

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
    }
}

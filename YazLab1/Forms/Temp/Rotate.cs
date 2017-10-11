using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace YazLab1.Forms
{
    public partial class Rotate : Form
    {
        private Stack<Image> imageStack = new Stack<Image>();
        private int isaret = 0; //TODO: ALTERNATİF BİR ÇÖZÜM BUL
        private Image image;
        public Rotate()
        {
            InitializeComponent();
           
            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion

            image = MainPageForm.SelectedImage;
            pbox_original.Image = image;
        }

        private void btn_rotate_Click(object sender, EventArgs e)
        {
            if (isaret == 0) // !!!!!!!!!!!!!!!!! BU NASIL KOD, UTAN KENDİNDEN :) !!!!!!!!!!!!!
            {
                imageStack.Push(pbox_original.Image);

                pbox_rotated.Image = ImageEdit.Rotate(image);

                isaret = 1;
            }
            else
            {
                imageStack.Push(pbox_rotated.Image);

                pbox_rotated.Image = ImageEdit.Rotate(pbox_rotated.Image);
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            if (imageStack.Count == 0)
            {
                MessageBox.Show("You cannot undo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pbox_rotated.Image = imageStack.Pop();
            }
        }
    }
}

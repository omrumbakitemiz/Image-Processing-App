﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YazLab1.Forms;

namespace YazLab1
{
    public partial class MainPageForm : Form
    {
        public static Image SelectedImage { get; set; }
        private string FileName;
        
        public MainPageForm()
        {
            InitializeComponent();

            #region Form Tasarım Ayarları
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            #endregion
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;

                SelectedImage = Image.FromFile(FileName);
                pictureBox.Image = SelectedImage;

                lbl_message.Text = "Please select an action";
                lbl_message.ForeColor = Color.Red;

                #region Image Information
                var imageWidth = SelectedImage.Width;
                var imageHeight = SelectedImage.Height;
                var imagePixelSum = imageWidth * imageHeight;

                #region İşlem Zaman Tahmini
                var estimatedProcessTime = "Unknown";

                if (imagePixelSum > 1000000) //One million
                {
                    estimatedProcessTime = "High";
                }
                else
                {
                    estimatedProcessTime = "Low";
                }
                #endregion

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append($"Width: {imageWidth}, Height: {imageHeight}, Estimated Process Time:");
                lbl_estimatedProcessTime.Text = $"{estimatedProcessTime}";
                if (lbl_estimatedProcessTime.Text == "High")
                {
                    lbl_estimatedProcessTime.ForeColor = Color.Red;
                    lbl_estimatedProcessTime.Font = new Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold);
                }
                else
                {
                    lbl_estimatedProcessTime.ForeColor = Color.Green;
                    lbl_estimatedProcessTime.Font = new Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Regular);
                }
                lbl_info.Text = stringBuilder.ToString();
                #endregion
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenHistogramForm()
        {
            if (FileName == null)
            {
                MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var histogramForm = new HistogramForm();

                Hide();

                histogramForm.Show();
            }
        }
        
        private void OpenColorChannelsForm()
        {
            if (FileName == null)
            {
                MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var colorChannelsForm = new ColorChannelsForm();

                Hide();

                colorChannelsForm.Show();
            }
        }
        
        #region Click Events

        private void btn_fileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btn_histogram_Click(object sender, EventArgs e)
        {
            OpenHistogramForm();
        }

        private void btn_colorChannels_Click(object sender, EventArgs e)
        {
            OpenColorChannelsForm();
        }

        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Application will be closed, Are you sure?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tempForm = new ImageEditForm();

            Hide();
            tempForm.Show();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tempForm = new ImageEditForm();

            Hide();
            tempForm.Show();
        }

        private void mirrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tempForm = new ImageEditForm();

            Hide();
            tempForm.Show();
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tempForm = new ImageEditForm();

            Hide();
            tempForm.Show();
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tempForm = new ImageEditForm();

            Hide();
            tempForm.Show();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHistogramForm();
        }

        private void colorChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenColorChannelsForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileAs();
        }

        private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReOpen();
        }

        private void toolStripMenuItem_suprise_Click(object sender, EventArgs e)
        {
            //Suprise();
        }
        #endregion
    }
}
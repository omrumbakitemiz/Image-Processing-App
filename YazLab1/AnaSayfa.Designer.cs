namespace YazLab1
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_fileOpen = new System.Windows.Forms.Button();
            this.btn_Mirror = new System.Windows.Forms.Button();
            this.btn_grayscale = new System.Windows.Forms.Button();
            this.btn_colorChannels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(780, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(771, 625);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1554, 631);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btn_fileOpen
            // 
            this.btn_fileOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_fileOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fileOpen.Location = new System.Drawing.Point(86, 930);
            this.btn_fileOpen.Name = "btn_fileOpen";
            this.btn_fileOpen.Size = new System.Drawing.Size(226, 94);
            this.btn_fileOpen.TabIndex = 9;
            this.btn_fileOpen.Text = "File Open";
            this.btn_fileOpen.UseVisualStyleBackColor = true;
            this.btn_fileOpen.Click += new System.EventHandler(this.btn_fileOpen_Click);
            // 
            // btn_Mirror
            // 
            this.btn_Mirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Mirror.Location = new System.Drawing.Point(348, 930);
            this.btn_Mirror.Name = "btn_Mirror";
            this.btn_Mirror.Size = new System.Drawing.Size(226, 94);
            this.btn_Mirror.TabIndex = 5;
            this.btn_Mirror.Text = "Mirror";
            this.btn_Mirror.UseVisualStyleBackColor = true;
            this.btn_Mirror.Click += new System.EventHandler(this.btn_Mirror_Click);
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_grayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grayscale.Location = new System.Drawing.Point(620, 930);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(226, 94);
            this.btn_grayscale.TabIndex = 10;
            this.btn_grayscale.Text = "Grayscale";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // btn_colorChannels
            // 
            this.btn_colorChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_colorChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_colorChannels.Location = new System.Drawing.Point(879, 930);
            this.btn_colorChannels.Name = "btn_colorChannels";
            this.btn_colorChannels.Size = new System.Drawing.Size(213, 94);
            this.btn_colorChannels.TabIndex = 11;
            this.btn_colorChannels.Text = "Color Channels";
            this.btn_colorChannels.UseVisualStyleBackColor = true;
            this.btn_colorChannels.Click += new System.EventHandler(this.btn_colorChannels_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1554, 1059);
            this.Controls.Add(this.btn_colorChannels);
            this.Controls.Add(this.btn_grayscale);
            this.Controls.Add(this.btn_fileOpen);
            this.Controls.Add(this.btn_Mirror);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_fileOpen;
        private System.Windows.Forms.Button btn_Mirror;
        private System.Windows.Forms.Button btn_grayscale;
        private System.Windows.Forms.Button btn_colorChannels;
    }
}


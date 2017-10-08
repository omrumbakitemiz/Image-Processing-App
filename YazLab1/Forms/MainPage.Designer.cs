namespace YazLab1
{
    partial class MainPage
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_histogram = new System.Windows.Forms.Button();
            this.btn_negative = new System.Windows.Forms.Button();
            this.btn_mirror = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.btn_scale = new System.Windows.Forms.Button();
            this.btn_reopen = new System.Windows.Forms.Button();
            this.btn_grayscale = new System.Windows.Forms.Button();
            this.btn_colorChannels = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_fileOpen = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_estimatedProcessTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1798, 843);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btn_histogram
            // 
            this.btn_histogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_histogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_histogram.Location = new System.Drawing.Point(15, 15);
            this.btn_histogram.Margin = new System.Windows.Forms.Padding(15);
            this.btn_histogram.Name = "btn_histogram";
            this.btn_histogram.Size = new System.Drawing.Size(164, 75);
            this.btn_histogram.TabIndex = 0;
            this.btn_histogram.Text = "Histogram";
            this.btn_histogram.UseVisualStyleBackColor = true;
            this.btn_histogram.Click += new System.EventHandler(this.btn_histogram_Click);
            // 
            // btn_negative
            // 
            this.btn_negative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_negative.Location = new System.Drawing.Point(209, 15);
            this.btn_negative.Margin = new System.Windows.Forms.Padding(15);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(164, 75);
            this.btn_negative.TabIndex = 2;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = true;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // btn_mirror
            // 
            this.btn_mirror.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mirror.Location = new System.Drawing.Point(403, 15);
            this.btn_mirror.Margin = new System.Windows.Forms.Padding(15);
            this.btn_mirror.Name = "btn_mirror";
            this.btn_mirror.Size = new System.Drawing.Size(164, 75);
            this.btn_mirror.TabIndex = 3;
            this.btn_mirror.Text = "Mirror";
            this.btn_mirror.UseVisualStyleBackColor = true;
            this.btn_mirror.Click += new System.EventHandler(this.btn_mirror_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rotate.Location = new System.Drawing.Point(597, 15);
            this.btn_rotate.Margin = new System.Windows.Forms.Padding(15);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(164, 75);
            this.btn_rotate.TabIndex = 4;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            // 
            // btn_scale
            // 
            this.btn_scale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scale.Location = new System.Drawing.Point(791, 15);
            this.btn_scale.Margin = new System.Windows.Forms.Padding(15);
            this.btn_scale.Name = "btn_scale";
            this.btn_scale.Size = new System.Drawing.Size(164, 75);
            this.btn_scale.TabIndex = 5;
            this.btn_scale.Text = "Scale";
            this.btn_scale.UseVisualStyleBackColor = true;
            // 
            // btn_reopen
            // 
            this.btn_reopen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_reopen.Location = new System.Drawing.Point(985, 15);
            this.btn_reopen.Margin = new System.Windows.Forms.Padding(15);
            this.btn_reopen.Name = "btn_reopen";
            this.btn_reopen.Size = new System.Drawing.Size(164, 75);
            this.btn_reopen.TabIndex = 6;
            this.btn_reopen.Text = "Reopen";
            this.btn_reopen.UseVisualStyleBackColor = true;
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_grayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grayscale.Location = new System.Drawing.Point(1179, 15);
            this.btn_grayscale.Margin = new System.Windows.Forms.Padding(15);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(164, 75);
            this.btn_grayscale.TabIndex = 7;
            this.btn_grayscale.Text = "Grayscale";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // btn_colorChannels
            // 
            this.btn_colorChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_colorChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_colorChannels.Location = new System.Drawing.Point(1373, 15);
            this.btn_colorChannels.Margin = new System.Windows.Forms.Padding(15);
            this.btn_colorChannels.Name = "btn_colorChannels";
            this.btn_colorChannels.Size = new System.Drawing.Size(170, 75);
            this.btn_colorChannels.TabIndex = 8;
            this.btn_colorChannels.Text = "Color Channels";
            this.btn_colorChannels.UseVisualStyleBackColor = true;
            this.btn_colorChannels.Click += new System.EventHandler(this.btn_colorChannels_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.btn_histogram, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_colorChannels, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_negative, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_grayscale, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_mirror, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_reopen, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_rotate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_scale, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(123, 1081);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1558, 105);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_fileOpen, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_message, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.29752F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.033058F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.181818F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48761F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1804, 1211);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btn_fileOpen
            // 
            this.btn_fileOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fileOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fileOpen.Location = new System.Drawing.Point(823, 994);
            this.btn_fileOpen.Name = "btn_fileOpen";
            this.btn_fileOpen.Size = new System.Drawing.Size(157, 75);
            this.btn_fileOpen.TabIndex = 10;
            this.btn_fileOpen.Text = "Open File";
            this.btn_fileOpen.UseVisualStyleBackColor = true;
            this.btn_fileOpen.Click += new System.EventHandler(this.btn_fileOpen_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.ForeColor = System.Drawing.Color.Blue;
            this.lbl_message.Location = new System.Drawing.Point(743, 934);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(317, 33);
            this.lbl_message.TabIndex = 11;
            this.lbl_message.Text = "Please select an image";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.34483F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.65517F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_info, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_estimatedProcessTime, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 852);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1798, 62);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(1081, 14);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 33);
            this.lbl_info.TabIndex = 13;
            // 
            // lbl_estimatedProcessTime
            // 
            this.lbl_estimatedProcessTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_estimatedProcessTime.AutoSize = true;
            this.lbl_estimatedProcessTime.Location = new System.Drawing.Point(1087, 15);
            this.lbl_estimatedProcessTime.Name = "lbl_estimatedProcessTime";
            this.lbl_estimatedProcessTime.Size = new System.Drawing.Size(0, 31);
            this.lbl_estimatedProcessTime.TabIndex = 14;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1804, 1211);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_histogram;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.Button btn_mirror;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button btn_scale;
        private System.Windows.Forms.Button btn_reopen;
        private System.Windows.Forms.Button btn_grayscale;
        private System.Windows.Forms.Button btn_colorChannels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_fileOpen;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_estimatedProcessTime;
    }
}
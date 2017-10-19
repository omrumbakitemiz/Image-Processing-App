namespace YazLab1
{
    partial class ColorChannelsForm
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
            this.pbox_redColorChannel = new System.Windows.Forms.PictureBox();
            this.pbox_greenColorChannel = new System.Windows.Forms.PictureBox();
            this.pbox_blueColorChannel = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox_mainImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_colorChannels = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_pickBlueChannel = new System.Windows.Forms.Button();
            this.btn_pickRedChannel = new System.Windows.Forms.Button();
            this.btn_pickGreenChannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_redColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_greenColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueColorChannel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_mainImage)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_redColorChannel
            // 
            this.pbox_redColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_redColorChannel.Location = new System.Drawing.Point(3, 3);
            this.pbox_redColorChannel.Name = "pbox_redColorChannel";
            this.pbox_redColorChannel.Size = new System.Drawing.Size(484, 421);
            this.pbox_redColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_redColorChannel.TabIndex = 0;
            this.pbox_redColorChannel.TabStop = false;
            // 
            // pbox_greenColorChannel
            // 
            this.pbox_greenColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_greenColorChannel.Location = new System.Drawing.Point(493, 3);
            this.pbox_greenColorChannel.Name = "pbox_greenColorChannel";
            this.pbox_greenColorChannel.Size = new System.Drawing.Size(484, 421);
            this.pbox_greenColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_greenColorChannel.TabIndex = 1;
            this.pbox_greenColorChannel.TabStop = false;
            // 
            // pbox_blueColorChannel
            // 
            this.pbox_blueColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_blueColorChannel.Location = new System.Drawing.Point(983, 3);
            this.pbox_blueColorChannel.Name = "pbox_blueColorChannel";
            this.pbox_blueColorChannel.Size = new System.Drawing.Size(484, 421);
            this.pbox_blueColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_blueColorChannel.TabIndex = 2;
            this.pbox_blueColorChannel.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbox_mainImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1476, 979);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.pbox_redColorChannel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbox_greenColorChannel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbox_blueColorChannel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 379);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1470, 370);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // pbox_mainImage
            // 
            this.pbox_mainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_mainImage.Location = new System.Drawing.Point(3, 3);
            this.pbox_mainImage.Name = "pbox_mainImage";
            this.pbox_mainImage.Size = new System.Drawing.Size(1470, 370);
            this.pbox_mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_mainImage.TabIndex = 7;
            this.pbox_mainImage.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_colorChannels, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_back, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 868);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1470, 108);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // btn_colorChannels
            // 
            this.btn_colorChannels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_colorChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_colorChannels.Location = new System.Drawing.Point(215, 18);
            this.btn_colorChannels.Name = "btn_colorChannels";
            this.btn_colorChannels.Size = new System.Drawing.Size(305, 71);
            this.btn_colorChannels.TabIndex = 5;
            this.btn_colorChannels.Text = "Renk Kanalları";
            this.btn_colorChannels.UseVisualStyleBackColor = true;
            this.btn_colorChannels.Click += new System.EventHandler(this.btn_colorChannels_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(969, 18);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(267, 71);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Önceki Menü";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btn_pickGreenChannel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_pickRedChannel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_pickBlueChannel, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 755);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1470, 107);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btn_pickBlueChannel
            // 
            this.btn_pickBlueChannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pickBlueChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pickBlueChannel.Location = new System.Drawing.Point(1118, 12);
            this.btn_pickBlueChannel.Name = "btn_pickBlueChannel";
            this.btn_pickBlueChannel.Size = new System.Drawing.Size(211, 83);
            this.btn_pickBlueChannel.TabIndex = 0;
            this.btn_pickBlueChannel.Text = "Seç";
            this.btn_pickBlueChannel.UseVisualStyleBackColor = true;
            this.btn_pickBlueChannel.Click += new System.EventHandler(this.btn_pickBlueChannel_Click);
            // 
            // btn_pickRedChannel
            // 
            this.btn_pickRedChannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pickRedChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pickRedChannel.Location = new System.Drawing.Point(139, 12);
            this.btn_pickRedChannel.Name = "btn_pickRedChannel";
            this.btn_pickRedChannel.Size = new System.Drawing.Size(211, 83);
            this.btn_pickRedChannel.TabIndex = 1;
            this.btn_pickRedChannel.Text = "Seç";
            this.btn_pickRedChannel.UseVisualStyleBackColor = true;
            this.btn_pickRedChannel.Click += new System.EventHandler(this.btn_pickRedChannel_Click);
            // 
            // btn_pickGreenChannel
            // 
            this.btn_pickGreenChannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pickGreenChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pickGreenChannel.Location = new System.Drawing.Point(628, 12);
            this.btn_pickGreenChannel.Name = "btn_pickGreenChannel";
            this.btn_pickGreenChannel.Size = new System.Drawing.Size(211, 83);
            this.btn_pickGreenChannel.TabIndex = 2;
            this.btn_pickGreenChannel.Text = "Seç";
            this.btn_pickGreenChannel.UseVisualStyleBackColor = true;
            this.btn_pickGreenChannel.Click += new System.EventHandler(this.btn_pickGreenChannel_Click);
            // 
            // ColorChannelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1476, 979);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ColorChannelsForm";
            this.Text = "Color Channels";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_redColorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_greenColorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueColorChannel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_mainImage)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_redColorChannel;
        private System.Windows.Forms.PictureBox pbox_greenColorChannel;
        private System.Windows.Forms.PictureBox pbox_blueColorChannel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbox_mainImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_colorChannels;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_pickGreenChannel;
        private System.Windows.Forms.Button btn_pickRedChannel;
        private System.Windows.Forms.Button btn_pickBlueChannel;
    }
}
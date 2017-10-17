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
            ((System.ComponentModel.ISupportInitialize)(this.pbox_redColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_greenColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueColorChannel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_mainImage)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbox_mainImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 436);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1470, 427);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // pbox_mainImage
            // 
            this.pbox_mainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_mainImage.Location = new System.Drawing.Point(3, 3);
            this.pbox_mainImage.Name = "pbox_mainImage";
            this.pbox_mainImage.Size = new System.Drawing.Size(1470, 427);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(185, 890);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1166, 77);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // btn_colorChannels
            // 
            this.btn_colorChannels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_colorChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_colorChannels.Location = new System.Drawing.Point(139, 3);
            this.btn_colorChannels.Name = "btn_colorChannels";
            this.btn_colorChannels.Size = new System.Drawing.Size(305, 71);
            this.btn_colorChannels.TabIndex = 5;
            this.btn_colorChannels.Text = "Color Channels";
            this.btn_colorChannels.UseVisualStyleBackColor = true;
            this.btn_colorChannels.Click += new System.EventHandler(this.btn_colorChannels_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(741, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(267, 71);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ColorChannelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1476, 979);
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
    }
}
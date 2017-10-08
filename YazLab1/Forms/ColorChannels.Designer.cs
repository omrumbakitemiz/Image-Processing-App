namespace YazLab1
{
    partial class ColorChannels
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
            this.btn_colorChannels = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox_mainImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_redColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_greenColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueColorChannel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_mainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_redColorChannel
            // 
            this.pbox_redColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_redColorChannel.Location = new System.Drawing.Point(3, 3);
            this.pbox_redColorChannel.Name = "pbox_redColorChannel";
            this.pbox_redColorChannel.Size = new System.Drawing.Size(483, 421);
            this.pbox_redColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_redColorChannel.TabIndex = 0;
            this.pbox_redColorChannel.TabStop = false;
            // 
            // pbox_greenColorChannel
            // 
            this.pbox_greenColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_greenColorChannel.Location = new System.Drawing.Point(492, 3);
            this.pbox_greenColorChannel.Name = "pbox_greenColorChannel";
            this.pbox_greenColorChannel.Size = new System.Drawing.Size(483, 421);
            this.pbox_greenColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_greenColorChannel.TabIndex = 1;
            this.pbox_greenColorChannel.TabStop = false;
            // 
            // pbox_blueColorChannel
            // 
            this.pbox_blueColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbox_blueColorChannel.Location = new System.Drawing.Point(981, 3);
            this.pbox_blueColorChannel.Name = "pbox_blueColorChannel";
            this.pbox_blueColorChannel.Size = new System.Drawing.Size(486, 421);
            this.pbox_blueColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_blueColorChannel.TabIndex = 2;
            this.pbox_blueColorChannel.TabStop = false;
            // 
            // btn_colorChannels
            // 
            this.btn_colorChannels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_colorChannels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_colorChannels.Location = new System.Drawing.Point(585, 871);
            this.btn_colorChannels.Name = "btn_colorChannels";
            this.btn_colorChannels.Size = new System.Drawing.Size(305, 103);
            this.btn_colorChannels.TabIndex = 4;
            this.btn_colorChannels.Text = "Color Channels";
            this.btn_colorChannels.UseVisualStyleBackColor = true;
            this.btn_colorChannels.Click += new System.EventHandler(this.btn_colorChannels_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_colorChannels, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbox_mainImage, 0, 0);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // ColorChannels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1476, 979);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ColorChannels";
            this.Text = "Color Channels";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_redColorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_greenColorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_blueColorChannel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_mainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_redColorChannel;
        private System.Windows.Forms.PictureBox pbox_greenColorChannel;
        private System.Windows.Forms.PictureBox pbox_blueColorChannel;
        private System.Windows.Forms.Button btn_colorChannels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbox_mainImage;
    }
}
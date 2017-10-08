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
            this.redColorChannel = new System.Windows.Forms.PictureBox();
            this.greenColorChannel = new System.Windows.Forms.PictureBox();
            this.blueColorChannel = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.redColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorChannel)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // redColorChannel
            // 
            this.redColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redColorChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redColorChannel.Location = new System.Drawing.Point(3, 3);
            this.redColorChannel.Name = "redColorChannel";
            this.redColorChannel.Size = new System.Drawing.Size(478, 738);
            this.redColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redColorChannel.TabIndex = 0;
            this.redColorChannel.TabStop = false;
            // 
            // greenColorChannel
            // 
            this.greenColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenColorChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenColorChannel.Location = new System.Drawing.Point(487, 3);
            this.greenColorChannel.Name = "greenColorChannel";
            this.greenColorChannel.Size = new System.Drawing.Size(478, 738);
            this.greenColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenColorChannel.TabIndex = 1;
            this.greenColorChannel.TabStop = false;
            // 
            // blueColorChannel
            // 
            this.blueColorChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueColorChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueColorChannel.Location = new System.Drawing.Point(971, 3);
            this.blueColorChannel.Name = "blueColorChannel";
            this.blueColorChannel.Size = new System.Drawing.Size(478, 738);
            this.blueColorChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueColorChannel.TabIndex = 2;
            this.blueColorChannel.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.redColorChannel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.blueColorChannel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.greenColorChannel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1452, 744);
            this.tableLayoutPanel1.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.redColorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorChannel)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redColorChannel;
        private System.Windows.Forms.PictureBox greenColorChannel;
        private System.Windows.Forms.PictureBox blueColorChannel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
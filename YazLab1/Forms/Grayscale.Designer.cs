namespace YazLab1.Forms
{
    partial class Grayscale
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_grayscale = new System.Windows.Forms.Button();
            this.pbox_normal = new System.Windows.Forms.PictureBox();
            this.pbox_grayscale = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_grayscale)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_grayscale, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82973F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17027F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1458, 1063);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pbox_grayscale, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbox_normal, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1452, 916);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_grayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grayscale.Location = new System.Drawing.Point(600, 948);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(257, 89);
            this.btn_grayscale.TabIndex = 2;
            this.btn_grayscale.Text = "Grayscale";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // pbox_normal
            // 
            this.pbox_normal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_normal.Location = new System.Drawing.Point(3, 3);
            this.pbox_normal.Name = "pbox_normal";
            this.pbox_normal.Size = new System.Drawing.Size(720, 910);
            this.pbox_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_normal.TabIndex = 0;
            this.pbox_normal.TabStop = false;
            // 
            // pbox_grayscale
            // 
            this.pbox_grayscale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_grayscale.Location = new System.Drawing.Point(729, 3);
            this.pbox_grayscale.Name = "pbox_grayscale";
            this.pbox_grayscale.Size = new System.Drawing.Size(720, 910);
            this.pbox_grayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_grayscale.TabIndex = 1;
            this.pbox_grayscale.TabStop = false;
            // 
            // Grayscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1458, 1063);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Grayscale";
            this.Text = "Grayscale";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_grayscale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbox_grayscale;
        private System.Windows.Forms.PictureBox pbox_normal;
        private System.Windows.Forms.Button btn_grayscale;
    }
}
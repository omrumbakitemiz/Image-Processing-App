namespace YazLab1
{
    partial class Negative
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
            this.btn_negative = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox_main = new System.Windows.Forms.PictureBox();
            this.pbox_negative = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_negative)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_negative
            // 
            this.btn_negative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_negative.Location = new System.Drawing.Point(603, 960);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(219, 85);
            this.btn_negative.TabIndex = 0;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = true;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_negative, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.91288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08712F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1426, 1079);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pbox_negative, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbox_main, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1420, 920);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pbox_main
            // 
            this.pbox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_main.Location = new System.Drawing.Point(3, 3);
            this.pbox_main.Name = "pbox_main";
            this.pbox_main.Size = new System.Drawing.Size(704, 914);
            this.pbox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_main.TabIndex = 2;
            this.pbox_main.TabStop = false;
            // 
            // pbox_negative
            // 
            this.pbox_negative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_negative.Location = new System.Drawing.Point(713, 3);
            this.pbox_negative.Name = "pbox_negative";
            this.pbox_negative.Size = new System.Drawing.Size(704, 914);
            this.pbox_negative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_negative.TabIndex = 3;
            this.pbox_negative.TabStop = false;
            // 
            // Negative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1426, 1079);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Negative";
            this.Text = "Negative";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_negative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbox_negative;
        private System.Windows.Forms.PictureBox pbox_main;
    }
}
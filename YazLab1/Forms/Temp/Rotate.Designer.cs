namespace YazLab1.Forms
{
    partial class Rotate
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
            this.pbox_original = new System.Windows.Forms.PictureBox();
            this.pbox_rotated = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.btn_undo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_rotated)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.74274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.257266F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 929);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pbox_original, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbox_rotated, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1208, 837);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pbox_original
            // 
            this.pbox_original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_original.Location = new System.Drawing.Point(3, 3);
            this.pbox_original.Name = "pbox_original";
            this.pbox_original.Size = new System.Drawing.Size(598, 831);
            this.pbox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_original.TabIndex = 0;
            this.pbox_original.TabStop = false;
            // 
            // pbox_rotated
            // 
            this.pbox_rotated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_rotated.Location = new System.Drawing.Point(607, 3);
            this.pbox_rotated.Name = "pbox_rotated";
            this.pbox_rotated.Size = new System.Drawing.Size(598, 831);
            this.pbox_rotated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_rotated.TabIndex = 1;
            this.pbox_rotated.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_undo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_rotate, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 846);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1208, 80);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rotate.Location = new System.Drawing.Point(733, 5);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(346, 69);
            this.btn_rotate.TabIndex = 2;
            this.btn_rotate.Text = "Rotate (Clockwise)";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_undo.Location = new System.Drawing.Point(213, 5);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(178, 69);
            this.btn_undo.TabIndex = 3;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // Rotate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1214, 929);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Rotate";
            this.Text = "Rotate";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_rotated)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbox_original;
        private System.Windows.Forms.PictureBox pbox_rotated;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Button btn_rotate;
    }
}
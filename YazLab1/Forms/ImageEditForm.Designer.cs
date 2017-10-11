namespace YazLab1.Forms
{
    partial class ImageEditForm
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
            this.btn_negative = new System.Windows.Forms.Button();
            this.btn_grayscale = new System.Windows.Forms.Button();
            this.btn_mirror = new System.Windows.Forms.Button();
            this.btn_rotate = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox_original = new System.Windows.Forms.PictureBox();
            this.pbox_edited = new System.Windows.Forms.PictureBox();
            this.btn_undo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_edited)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.12302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.87697F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1836, 1203);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_negative, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_grayscale, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_mirror, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_rotate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_undo, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1015);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1830, 185);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_negative
            // 
            this.btn_negative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_negative.Location = new System.Drawing.Point(1183, 39);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(196, 106);
            this.btn_negative.TabIndex = 4;
            this.btn_negative.Text = "Negative";
            this.btn_negative.UseVisualStyleBackColor = true;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_grayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grayscale.Location = new System.Drawing.Point(85, 39);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(196, 106);
            this.btn_grayscale.TabIndex = 1;
            this.btn_grayscale.Text = "Grayscale";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // btn_mirror
            // 
            this.btn_mirror.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mirror.Location = new System.Drawing.Point(817, 39);
            this.btn_mirror.Name = "btn_mirror";
            this.btn_mirror.Size = new System.Drawing.Size(196, 106);
            this.btn_mirror.TabIndex = 3;
            this.btn_mirror.Text = "Mirror";
            this.btn_mirror.UseVisualStyleBackColor = true;
            this.btn_mirror.Click += new System.EventHandler(this.btn_mirror_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rotate.Location = new System.Drawing.Point(451, 39);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(196, 106);
            this.btn_rotate.TabIndex = 2;
            this.btn_rotate.Text = "Rotate";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pbox_original, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbox_edited, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1830, 1006);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pbox_original
            // 
            this.pbox_original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_original.Location = new System.Drawing.Point(3, 3);
            this.pbox_original.Name = "pbox_original";
            this.pbox_original.Size = new System.Drawing.Size(909, 1000);
            this.pbox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_original.TabIndex = 0;
            this.pbox_original.TabStop = false;
            // 
            // pbox_edited
            // 
            this.pbox_edited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_edited.Location = new System.Drawing.Point(918, 3);
            this.pbox_edited.Name = "pbox_edited";
            this.pbox_edited.Size = new System.Drawing.Size(909, 1000);
            this.pbox_edited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_edited.TabIndex = 1;
            this.pbox_edited.TabStop = false;
            // 
            // btn_undo
            // 
            this.btn_undo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_undo.Location = new System.Drawing.Point(1549, 39);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(196, 106);
            this.btn_undo.TabIndex = 5;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1836, 1203);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Temp";
            this.Text = "Temp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_edited)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_grayscale;
        private System.Windows.Forms.Button btn_rotate;
        private System.Windows.Forms.Button btn_mirror;
        private System.Windows.Forms.Button btn_negative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pbox_original;
        private System.Windows.Forms.PictureBox pbox_edited;
        private System.Windows.Forms.Button btn_undo;
    }
}
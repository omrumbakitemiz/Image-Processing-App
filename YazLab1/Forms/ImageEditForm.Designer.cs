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
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_backtoMainPage = new System.Windows.Forms.Button();
            this.btn_scale = new System.Windows.Forms.Button();
            this.txb_scaleRate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pbox_original = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbox_edited = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_histogram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_colorChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_edited)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.6612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.0765F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.19126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.85792F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.87978F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.196721F));
            this.tableLayoutPanel2.Controls.Add(this.btn_negative, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_grayscale, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_mirror, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_rotate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_undo, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_backtoMainPage, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_scale, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txb_scaleRate, 7, 0);
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
            this.btn_negative.Location = new System.Drawing.Point(720, 39);
            this.btn_negative.Name = "btn_negative";
            this.btn_negative.Size = new System.Drawing.Size(196, 106);
            this.btn_negative.TabIndex = 4;
            this.btn_negative.Text = "Negatif";
            this.btn_negative.UseVisualStyleBackColor = true;
            this.btn_negative.Click += new System.EventHandler(this.btn_negative_Click);
            // 
            // btn_grayscale
            // 
            this.btn_grayscale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_grayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_grayscale.Location = new System.Drawing.Point(16, 39);
            this.btn_grayscale.Name = "btn_grayscale";
            this.btn_grayscale.Size = new System.Drawing.Size(196, 106);
            this.btn_grayscale.TabIndex = 1;
            this.btn_grayscale.Text = "Gri Tonlama";
            this.btn_grayscale.UseVisualStyleBackColor = true;
            this.btn_grayscale.Click += new System.EventHandler(this.btn_grayscale_Click);
            // 
            // btn_mirror
            // 
            this.btn_mirror.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mirror.Location = new System.Drawing.Point(485, 39);
            this.btn_mirror.Name = "btn_mirror";
            this.btn_mirror.Size = new System.Drawing.Size(196, 106);
            this.btn_mirror.TabIndex = 3;
            this.btn_mirror.Text = "Aynala";
            this.btn_mirror.UseVisualStyleBackColor = true;
            this.btn_mirror.Click += new System.EventHandler(this.btn_mirror_Click);
            // 
            // btn_rotate
            // 
            this.btn_rotate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rotate.Location = new System.Drawing.Point(245, 39);
            this.btn_rotate.Name = "btn_rotate";
            this.btn_rotate.Size = new System.Drawing.Size(196, 106);
            this.btn_rotate.TabIndex = 2;
            this.btn_rotate.Text = "Döndür";
            this.btn_rotate.UseVisualStyleBackColor = true;
            this.btn_rotate.Click += new System.EventHandler(this.btn_rotate_Click);
            // 
            // btn_undo
            // 
            this.btn_undo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_undo.Location = new System.Drawing.Point(970, 39);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(196, 106);
            this.btn_undo.TabIndex = 5;
            this.btn_undo.Text = "Geri Al";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.btn_undo_Click);
            // 
            // btn_backtoMainPage
            // 
            this.btn_backtoMainPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_backtoMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_backtoMainPage.Location = new System.Drawing.Point(1217, 39);
            this.btn_backtoMainPage.Name = "btn_backtoMainPage";
            this.btn_backtoMainPage.Size = new System.Drawing.Size(196, 106);
            this.btn_backtoMainPage.TabIndex = 6;
            this.btn_backtoMainPage.Text = "Önceki Menü";
            this.btn_backtoMainPage.UseVisualStyleBackColor = true;
            this.btn_backtoMainPage.Click += new System.EventHandler(this.btn_backtoMainPage_Click);
            // 
            // btn_scale
            // 
            this.btn_scale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scale.Location = new System.Drawing.Point(1453, 39);
            this.btn_scale.Name = "btn_scale";
            this.btn_scale.Size = new System.Drawing.Size(196, 106);
            this.btn_scale.TabIndex = 7;
            this.btn_scale.Text = "Ölçeklendir";
            this.btn_scale.UseVisualStyleBackColor = true;
            this.btn_scale.Click += new System.EventHandler(this.btn_scale_Click);
            // 
            // txb_scaleRate
            // 
            this.txb_scaleRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_scaleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_scaleRate.Location = new System.Drawing.Point(1694, 72);
            this.txb_scaleRate.Name = "txb_scaleRate";
            this.txb_scaleRate.Size = new System.Drawing.Size(120, 40);
            this.txb_scaleRate.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pbox_original, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.pbox_edited);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(918, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 1000);
            this.panel1.TabIndex = 1;
            // 
            // pbox_edited
            // 
            this.pbox_edited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_edited.Location = new System.Drawing.Point(0, 0);
            this.pbox_edited.Name = "pbox_edited";
            this.pbox_edited.Size = new System.Drawing.Size(909, 1000);
            this.pbox_edited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_edited.TabIndex = 2;
            this.pbox_edited.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_file,
            this.toolStripMenuItem_edit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1836, 48);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip";
            // 
            // toolStripMenuItem_file
            // 
            this.toolStripMenuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.reopenToolStripMenuItem});
            this.toolStripMenuItem_file.Name = "toolStripMenuItem_file";
            this.toolStripMenuItem_file.Size = new System.Drawing.Size(107, 44);
            this.toolStripMenuItem_file.Text = "Dosya";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 44);
            this.saveToolStripMenuItem.Text = "Kaydet";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // reopenToolStripMenuItem
            // 
            this.reopenToolStripMenuItem.Name = "reopenToolStripMenuItem";
            this.reopenToolStripMenuItem.Size = new System.Drawing.Size(234, 44);
            this.reopenToolStripMenuItem.Text = "Tekrar Aç";
            this.reopenToolStripMenuItem.Click += new System.EventHandler(this.reopenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_edit
            // 
            this.toolStripMenuItem_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_histogram,
            this.toolStripMenuItem_colorChannel});
            this.toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            this.toolStripMenuItem_edit.Size = new System.Drawing.Size(131, 44);
            this.toolStripMenuItem_edit.Text = "Düzenle";
            // 
            // toolStripMenuItem_histogram
            // 
            this.toolStripMenuItem_histogram.Name = "toolStripMenuItem_histogram";
            this.toolStripMenuItem_histogram.Size = new System.Drawing.Size(296, 44);
            this.toolStripMenuItem_histogram.Text = "Histogram";
            this.toolStripMenuItem_histogram.Click += new System.EventHandler(this.toolStripMenuItem_histogram_Click);
            // 
            // toolStripMenuItem_colorChannel
            // 
            this.toolStripMenuItem_colorChannel.Name = "toolStripMenuItem_colorChannel";
            this.toolStripMenuItem_colorChannel.Size = new System.Drawing.Size(296, 44);
            this.toolStripMenuItem_colorChannel.Text = "Renk Kanalları";
            this.toolStripMenuItem_colorChannel.Click += new System.EventHandler(this.toolStripMenuItem_colorChannel_Click);
            // 
            // ImageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1836, 1203);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageEditForm";
            this.Text = "Image Edit";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_original)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_edited)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_file;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btn_backtoMainPage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_histogram;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_colorChannel;
        private System.Windows.Forms.Button btn_scale;
        private System.Windows.Forms.TextBox txb_scaleRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox_edited;
        private System.Windows.Forms.ToolStripMenuItem reopenToolStripMenuItem;
    }
}
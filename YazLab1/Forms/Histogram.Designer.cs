﻿namespace YazLab1
{
    partial class Histogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.cboxBlue = new System.Windows.Forms.CheckBox();
            this.cboxGreen = new System.Windows.Forms.CheckBox();
            this.cboxRed = new System.Windows.Forms.CheckBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboxGrayscale = new System.Windows.Forms.CheckBox();
            this.btn_undo = new System.Windows.Forms.Button();
            this.btn_mainPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxBlue
            // 
            this.cboxBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxBlue.AutoSize = true;
            this.cboxBlue.BackColor = System.Drawing.Color.Blue;
            this.cboxBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxBlue.ForeColor = System.Drawing.Color.White;
            this.cboxBlue.Location = new System.Drawing.Point(985, 16);
            this.cboxBlue.Name = "cboxBlue";
            this.cboxBlue.Size = new System.Drawing.Size(129, 55);
            this.cboxBlue.TabIndex = 6;
            this.cboxBlue.Text = "Blue";
            this.cboxBlue.UseVisualStyleBackColor = false;
            this.cboxBlue.CheckedChanged += new System.EventHandler(this.cboxBlue_CheckedChanged);
            // 
            // cboxGreen
            // 
            this.cboxGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxGreen.AutoSize = true;
            this.cboxGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.cboxGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxGreen.ForeColor = System.Drawing.Color.White;
            this.cboxGreen.Location = new System.Drawing.Point(716, 16);
            this.cboxGreen.Name = "cboxGreen";
            this.cboxGreen.Size = new System.Drawing.Size(157, 55);
            this.cboxGreen.TabIndex = 5;
            this.cboxGreen.Text = "Green";
            this.cboxGreen.UseVisualStyleBackColor = false;
            this.cboxGreen.CheckedChanged += new System.EventHandler(this.cboxGreen_CheckedChanged);
            // 
            // cboxRed
            // 
            this.cboxRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxRed.AutoSize = true;
            this.cboxRed.BackColor = System.Drawing.Color.Red;
            this.cboxRed.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxRed.ForeColor = System.Drawing.Color.White;
            this.cboxRed.Location = new System.Drawing.Point(479, 16);
            this.cboxRed.Name = "cboxRed";
            this.cboxRed.Size = new System.Drawing.Size(120, 55);
            this.cboxRed.TabIndex = 4;
            this.cboxRed.Text = "Red";
            this.cboxRed.UseVisualStyleBackColor = false;
            this.cboxRed.CheckedChanged += new System.EventHandler(this.cboxRed_CheckedChanged);
            // 
            // chartHistogram
            // 
            this.chartHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartHistogram.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea2);
            this.chartHistogram.Location = new System.Drawing.Point(3, 3);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(1502, 908);
            this.chartHistogram.TabIndex = 7;
            this.chartHistogram.Text = "Histogram";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartHistogram, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.71308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.28692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1508, 1031);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_mainPage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_undo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxGrayscale, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxRed, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxGreen, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxBlue, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(38, 929);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1432, 87);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // cboxGrayscale
            // 
            this.cboxGrayscale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxGrayscale.AutoSize = true;
            this.cboxGrayscale.BackColor = System.Drawing.Color.LightSlateGray;
            this.cboxGrayscale.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxGrayscale.ForeColor = System.Drawing.Color.White;
            this.cboxGrayscale.Location = new System.Drawing.Point(1195, 16);
            this.cboxGrayscale.Name = "cboxGrayscale";
            this.cboxGrayscale.Size = new System.Drawing.Size(218, 55);
            this.cboxGrayscale.TabIndex = 10;
            this.cboxGrayscale.Text = "Grayscale";
            this.cboxGrayscale.UseVisualStyleBackColor = false;
            this.cboxGrayscale.CheckedChanged += new System.EventHandler(this.cboxGrayscale_CheckedChanged);
            // 
            // btn_undo
            // 
            this.btn_undo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_undo.Location = new System.Drawing.Point(282, 16);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(119, 55);
            this.btn_undo.TabIndex = 9;
            this.btn_undo.Text = "Undo";
            this.btn_undo.UseVisualStyleBackColor = true;
            // 
            // btn_mainPage
            // 
            this.btn_mainPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainPage.Location = new System.Drawing.Point(38, 16);
            this.btn_mainPage.Name = "btn_mainPage";
            this.btn_mainPage.Size = new System.Drawing.Size(195, 55);
            this.btn_mainPage.TabIndex = 11;
            this.btn_mainPage.Text = "Main Page";
            this.btn_mainPage.UseVisualStyleBackColor = true;
            this.btn_mainPage.Click += new System.EventHandler(this.btn_mainPage_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1508, 1031);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Histogram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxBlue;
        private System.Windows.Forms.CheckBox cboxGreen;
        private System.Windows.Forms.CheckBox cboxRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cboxGrayscale;
        private System.Windows.Forms.Button btn_mainPage;
        private System.Windows.Forms.Button btn_undo;
    }
}
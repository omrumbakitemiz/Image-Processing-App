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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cboxBlue = new System.Windows.Forms.CheckBox();
            this.cboxGreen = new System.Windows.Forms.CheckBox();
            this.cboxRed = new System.Windows.Forms.CheckBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxBlue
            // 
            this.cboxBlue.AutoSize = true;
            this.cboxBlue.BackColor = System.Drawing.Color.Blue;
            this.cboxBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxBlue.ForeColor = System.Drawing.Color.White;
            this.cboxBlue.Location = new System.Drawing.Point(784, 266);
            this.cboxBlue.Name = "cboxBlue";
            this.cboxBlue.Size = new System.Drawing.Size(115, 49);
            this.cboxBlue.TabIndex = 6;
            this.cboxBlue.Text = "Blue";
            this.cboxBlue.UseVisualStyleBackColor = false;
            // 
            // cboxGreen
            // 
            this.cboxGreen.AutoSize = true;
            this.cboxGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.cboxGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxGreen.ForeColor = System.Drawing.Color.White;
            this.cboxGreen.Location = new System.Drawing.Point(784, 188);
            this.cboxGreen.Name = "cboxGreen";
            this.cboxGreen.Size = new System.Drawing.Size(139, 49);
            this.cboxGreen.TabIndex = 5;
            this.cboxGreen.Text = "Green";
            this.cboxGreen.UseVisualStyleBackColor = false;
            // 
            // cboxRed
            // 
            this.cboxRed.AutoSize = true;
            this.cboxRed.BackColor = System.Drawing.Color.Red;
            this.cboxRed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxRed.ForeColor = System.Drawing.Color.White;
            this.cboxRed.Location = new System.Drawing.Point(784, 110);
            this.cboxRed.Name = "cboxRed";
            this.cboxRed.Size = new System.Drawing.Size(107, 49);
            this.cboxRed.TabIndex = 4;
            this.cboxRed.Text = "Red";
            this.cboxRed.UseVisualStyleBackColor = false;
            // 
            // chartHistogram
            // 
            this.chartHistogram.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(12, 39);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(704, 491);
            this.chartHistogram.TabIndex = 7;
            this.chartHistogram.Text = "Histogram";
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 797);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.cboxBlue);
            this.Controls.Add(this.cboxGreen);
            this.Controls.Add(this.cboxRed);
            this.Name = "Histogram";
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxBlue;
        private System.Windows.Forms.CheckBox cboxGreen;
        private System.Windows.Forms.CheckBox cboxRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
    }
}
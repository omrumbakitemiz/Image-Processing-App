namespace YazLab1
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
            this.cboxBlue = new System.Windows.Forms.CheckBox();
            this.cboxGreen = new System.Windows.Forms.CheckBox();
            this.cboxRed = new System.Windows.Forms.CheckBox();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxBlue
            // 
            this.cboxBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBlue.AutoSize = true;
            this.cboxBlue.BackColor = System.Drawing.Color.Blue;
            this.cboxBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxBlue.ForeColor = System.Drawing.Color.White;
            this.cboxBlue.Location = new System.Drawing.Point(1272, 184);
            this.cboxBlue.Name = "cboxBlue";
            this.cboxBlue.Size = new System.Drawing.Size(115, 49);
            this.cboxBlue.TabIndex = 6;
            this.cboxBlue.Text = "Blue";
            this.cboxBlue.UseVisualStyleBackColor = false;
            // 
            // cboxGreen
            // 
            this.cboxGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxGreen.AutoSize = true;
            this.cboxGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.cboxGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxGreen.ForeColor = System.Drawing.Color.White;
            this.cboxGreen.Location = new System.Drawing.Point(1272, 104);
            this.cboxGreen.Name = "cboxGreen";
            this.cboxGreen.Size = new System.Drawing.Size(139, 49);
            this.cboxGreen.TabIndex = 5;
            this.cboxGreen.Text = "Green";
            this.cboxGreen.UseVisualStyleBackColor = false;
            // 
            // cboxRed
            // 
            this.cboxRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxRed.AutoSize = true;
            this.cboxRed.BackColor = System.Drawing.Color.Red;
            this.cboxRed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxRed.ForeColor = System.Drawing.Color.White;
            this.cboxRed.Location = new System.Drawing.Point(1272, 26);
            this.cboxRed.Name = "cboxRed";
            this.cboxRed.Size = new System.Drawing.Size(107, 49);
            this.cboxRed.TabIndex = 4;
            this.cboxRed.Text = "Red";
            this.cboxRed.UseVisualStyleBackColor = false;
            // 
            // chartHistogram
            // 
            this.chartHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chartHistogram.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            this.chartHistogram.Location = new System.Drawing.Point(22, 235);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(1168, 491);
            this.chartHistogram.TabIndex = 7;
            this.chartHistogram.Text = "Histogram";
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 1031);
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
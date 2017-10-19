namespace YazLab1
{
    partial class HistogramForm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.cboxGrayscale = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_saveChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxBlue
            // 
            this.cboxBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxBlue.AutoSize = true;
            this.cboxBlue.BackColor = System.Drawing.Color.Blue;
            this.cboxBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxBlue.ForeColor = System.Drawing.Color.White;
            this.cboxBlue.Location = new System.Drawing.Point(932, 13);
            this.cboxBlue.Name = "cboxBlue";
            this.cboxBlue.Size = new System.Drawing.Size(138, 55);
            this.cboxBlue.TabIndex = 6;
            this.cboxBlue.Text = "Mavi";
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
            this.cboxGreen.Location = new System.Drawing.Point(650, 13);
            this.cboxGreen.Name = "cboxGreen";
            this.cboxGreen.Size = new System.Drawing.Size(129, 55);
            this.cboxGreen.TabIndex = 5;
            this.cboxGreen.Text = "Yeşil";
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
            this.cboxRed.Location = new System.Drawing.Point(342, 13);
            this.cboxRed.Name = "cboxRed";
            this.cboxRed.Size = new System.Drawing.Size(173, 55);
            this.cboxRed.TabIndex = 4;
            this.cboxRed.Text = "Kırmızı";
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
            this.chartHistogram.Size = new System.Drawing.Size(1502, 789);
            this.chartHistogram.TabIndex = 7;
            this.chartHistogram.Text = "Histogram";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartHistogram, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.14181F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.86324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.02716F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1508, 1031);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_back, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxGrayscale, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxRed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxGreen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboxBlue, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(38, 810);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1432, 81);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.Location = new System.Drawing.Point(16, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(253, 55);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Önceki Menü";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cboxGrayscale
            // 
            this.cboxGrayscale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxGrayscale.AutoSize = true;
            this.cboxGrayscale.BackColor = System.Drawing.Color.LightSlateGray;
            this.cboxGrayscale.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxGrayscale.ForeColor = System.Drawing.Color.White;
            this.cboxGrayscale.Location = new System.Drawing.Point(1157, 13);
            this.cboxGrayscale.Name = "cboxGrayscale";
            this.cboxGrayscale.Size = new System.Drawing.Size(261, 55);
            this.cboxGrayscale.TabIndex = 10;
            this.cboxGrayscale.Text = "Gri Tonlama";
            this.cboxGrayscale.UseVisualStyleBackColor = false;
            this.cboxGrayscale.CheckedChanged += new System.EventHandler(this.cboxGrayscale_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_saveChart, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 909);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1502, 119);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // btn_saveChart
            // 
            this.btn_saveChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_saveChart.Location = new System.Drawing.Point(644, 14);
            this.btn_saveChart.Name = "btn_saveChart";
            this.btn_saveChart.Size = new System.Drawing.Size(213, 90);
            this.btn_saveChart.TabIndex = 0;
            this.btn_saveChart.Text = "Kaydet";
            this.btn_saveChart.UseVisualStyleBackColor = true;
            this.btn_saveChart.Click += new System.EventHandler(this.btn_saveChart_Click);
            // 
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1508, 1031);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistogramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_saveChart;
    }
}
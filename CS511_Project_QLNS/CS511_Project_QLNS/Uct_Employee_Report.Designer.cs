namespace CS511_Project_QLNS
{
    partial class Uct_Employee_Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_month = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.btn_by_month = new CS511_Project_QLNS.View.CustomButton();
            this.btn_all_the_time = new CS511_Project_QLNS.View.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.Location = new System.Drawing.Point(34, 183);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(100, 32);
            this.lbl_month.TabIndex = 66;
            this.lbl_month.Text = "Month:";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(1090, 307);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(545, 408);
            this.chart2.TabIndex = 65;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(70, 307);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(868, 379);
            this.chart1.TabIndex = 64;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1233, 779);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "Top 5 best-sellers";
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_revenue.Location = new System.Drawing.Point(321, 779);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(238, 26);
            this.lbl_revenue.TabIndex = 62;
            this.lbl_revenue.Text = "Revenue by all months";
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(203, 180);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(239, 40);
            this.cbb_month.TabIndex = 61;
            // 
            // btn_by_month
            // 
            this.btn_by_month.BackColor = System.Drawing.Color.Green;
            this.btn_by_month.BackgroundColor = System.Drawing.Color.Green;
            this.btn_by_month.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_by_month.BorderRadius = 0;
            this.btn_by_month.BorderSize = 0;
            this.btn_by_month.FlatAppearance.BorderSize = 0;
            this.btn_by_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_by_month.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_by_month.ForeColor = System.Drawing.Color.White;
            this.btn_by_month.Location = new System.Drawing.Point(870, 55);
            this.btn_by_month.Name = "btn_by_month";
            this.btn_by_month.Size = new System.Drawing.Size(870, 60);
            this.btn_by_month.TabIndex = 60;
            this.btn_by_month.Text = "By Month";
            this.btn_by_month.TextColor = System.Drawing.Color.White;
            this.btn_by_month.UseVisualStyleBackColor = false;
            // 
            // btn_all_the_time
            // 
            this.btn_all_the_time.BackColor = System.Drawing.Color.Green;
            this.btn_all_the_time.BackgroundColor = System.Drawing.Color.Green;
            this.btn_all_the_time.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_all_the_time.BorderRadius = 0;
            this.btn_all_the_time.BorderSize = 0;
            this.btn_all_the_time.FlatAppearance.BorderSize = 0;
            this.btn_all_the_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all_the_time.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_the_time.ForeColor = System.Drawing.Color.White;
            this.btn_all_the_time.Location = new System.Drawing.Point(0, 55);
            this.btn_all_the_time.Name = "btn_all_the_time";
            this.btn_all_the_time.Size = new System.Drawing.Size(870, 60);
            this.btn_all_the_time.TabIndex = 59;
            this.btn_all_the_time.Text = "All The Time";
            this.btn_all_the_time.TextColor = System.Drawing.Color.White;
            this.btn_all_the_time.UseVisualStyleBackColor = false;
            // 
            // Uct_Employee_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_revenue);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.btn_by_month);
            this.Controls.Add(this.btn_all_the_time);
            this.Name = "Uct_Employee_Report";
            this.Size = new System.Drawing.Size(1740, 930);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.ComboBox cbb_month;
        private View.CustomButton btn_by_month;
        private View.CustomButton btn_all_the_time;
    }
}

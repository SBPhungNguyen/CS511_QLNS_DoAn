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
            this.btn_cat1 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_all = new CS511_Project_QLNS.View.CustomButton();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cat1
            // 
            this.btn_cat1.BackColor = System.Drawing.Color.Green;
            this.btn_cat1.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat1.BorderRadius = 0;
            this.btn_cat1.BorderSize = 0;
            this.btn_cat1.FlatAppearance.BorderSize = 0;
            this.btn_cat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat1.ForeColor = System.Drawing.Color.White;
            this.btn_cat1.Location = new System.Drawing.Point(490, 58);
            this.btn_cat1.Name = "btn_cat1";
            this.btn_cat1.Size = new System.Drawing.Size(490, 40);
            this.btn_cat1.TabIndex = 44;
            this.btn_cat1.Text = "customButton2";
            this.btn_cat1.TextColor = System.Drawing.Color.White;
            this.btn_cat1.UseVisualStyleBackColor = false;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Green;
            this.btn_all.BackgroundColor = System.Drawing.Color.Green;
            this.btn_all.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_all.BorderRadius = 0;
            this.btn_all.BorderSize = 0;
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(0, 58);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(490, 40);
            this.btn_all.TabIndex = 43;
            this.btn_all.Text = "customButton1";
            this.btn_all.TextColor = System.Drawing.Color.White;
            this.btn_all.UseVisualStyleBackColor = false;
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(1, 119);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(220, 26);
            this.cbb_month.TabIndex = 45;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(62, 221);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(311, 300);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(573, 221);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 47;
            this.chart2.Text = "chart2";
            // 
            // Uct_Employee_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.btn_cat1);
            this.Controls.Add(this.btn_all);
            this.Name = "Uct_Employee_Report";
            this.Size = new System.Drawing.Size(980, 675);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomButton btn_cat1;
        private View.CustomButton btn_all;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

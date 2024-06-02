namespace CS511_Project_QLNS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_by_month = new CS511_Project_QLNS.View.CustomButton();
            this.btn_all_the_time = new CS511_Project_QLNS.View.CustomButton();
            this.ptb_em_pic = new CS511_Project_QLNS.View.CustomPictureBox();
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_chat = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnl_UserName = new System.Windows.Forms.Panel();
            this.lbl_em_name = new System.Windows.Forms.Label();
            this.btn_logout = new CS511_Project_QLNS.View.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_em_pic)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.pnl_UserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 40);
            this.panel1.TabIndex = 9;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1263, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Green;
            this.lbl_title.Location = new System.Drawing.Point(308, 74);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(116, 40);
            this.lbl_title.TabIndex = 12;
            this.lbl_title.Text = "HOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(985, 705);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Top 5 best-sellers";
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_revenue.Location = new System.Drawing.Point(523, 705);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(178, 20);
            this.lbl_revenue.TabIndex = 54;
            this.lbl_revenue.Text = "Revenue by all months";
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(316, 251);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(220, 26);
            this.cbb_month.TabIndex = 53;
            this.cbb_month.SelectedIndexChanged += new System.EventHandler(this.cbb_month_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(315, 346);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(539, 317);
            this.chart1.TabIndex = 56;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(875, 326);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(413, 300);
            this.chart2.TabIndex = 57;
            this.chart2.Text = "chart2";
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
            this.btn_by_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_by_month.ForeColor = System.Drawing.Color.White;
            this.btn_by_month.Location = new System.Drawing.Point(805, 188);
            this.btn_by_month.Name = "btn_by_month";
            this.btn_by_month.Size = new System.Drawing.Size(488, 40);
            this.btn_by_month.TabIndex = 52;
            this.btn_by_month.Text = "By Month";
            this.btn_by_month.TextColor = System.Drawing.Color.White;
            this.btn_by_month.UseVisualStyleBackColor = false;
            this.btn_by_month.Click += new System.EventHandler(this.btn_by_month_Click);
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
            this.btn_all_the_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all_the_time.ForeColor = System.Drawing.Color.White;
            this.btn_all_the_time.Location = new System.Drawing.Point(315, 188);
            this.btn_all_the_time.Name = "btn_all_the_time";
            this.btn_all_the_time.Size = new System.Drawing.Size(490, 40);
            this.btn_all_the_time.TabIndex = 51;
            this.btn_all_the_time.Text = "All The Time";
            this.btn_all_the_time.TextColor = System.Drawing.Color.White;
            this.btn_all_the_time.UseVisualStyleBackColor = false;
            this.btn_all_the_time.Click += new System.EventHandler(this.btn_all_the_time_Click);
            // 
            // ptb_em_pic
            // 
            this.ptb_em_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_em_pic.Border = 1;
            this.ptb_em_pic.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.ptb_em_pic.BorderStyle1 = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.ptb_em_pic.ColorBorder = System.Drawing.Color.RoyalBlue;
            this.ptb_em_pic.ColorBorder2 = System.Drawing.Color.HotPink;
            this.ptb_em_pic.Gradiant = 50F;
            this.ptb_em_pic.Location = new System.Drawing.Point(70, 135);
            this.ptb_em_pic.Name = "ptb_em_pic";
            this.ptb_em_pic.Size = new System.Drawing.Size(125, 115);
            this.ptb_em_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_em_pic.TabIndex = 10;
            this.ptb_em_pic.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Lime;
            this.customPanel1.Controls.Add(this.btn_employee);
            this.customPanel1.Controls.Add(this.btn_chat);
            this.customPanel1.Controls.Add(this.btn_report);
            this.customPanel1.Controls.Add(this.btn_import);
            this.customPanel1.Controls.Add(this.btn_home);
            this.customPanel1.Controls.Add(this.pnl_UserName);
            this.customPanel1.Controls.Add(this.btn_logout);
            this.customPanel1.Controls.Add(this.panel2);
            this.customPanel1.Location = new System.Drawing.Point(-9, 190);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 20;
            this.customPanel1.Size = new System.Drawing.Size(270, 611);
            this.customPanel1.TabIndex = 11;
            this.customPanel1.Thickness = 1F;
            // 
            // btn_employee
            // 
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(7, 421);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(260, 63);
            this.btn_employee.TabIndex = 15;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_chat
            // 
            this.btn_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_chat.FlatAppearance.BorderSize = 0;
            this.btn_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chat.ForeColor = System.Drawing.Color.White;
            this.btn_chat.Location = new System.Drawing.Point(7, 358);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(260, 63);
            this.btn_chat.TabIndex = 14;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = false;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(7, 296);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(260, 63);
            this.btn_report.TabIndex = 13;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(7, 233);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(260, 63);
            this.btn_import.TabIndex = 12;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(181)))), ((int)(((byte)(122)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(7, 170);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(260, 63);
            this.btn_home.TabIndex = 11;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnl_UserName
            // 
            this.pnl_UserName.Controls.Add(this.lbl_em_name);
            this.pnl_UserName.Location = new System.Drawing.Point(21, 76);
            this.pnl_UserName.Name = "pnl_UserName";
            this.pnl_UserName.Size = new System.Drawing.Size(243, 64);
            this.pnl_UserName.TabIndex = 10;
            // 
            // lbl_em_name
            // 
            this.lbl_em_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_em_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_em_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_em_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_em_name.Name = "lbl_em_name";
            this.lbl_em_name.Size = new System.Drawing.Size(243, 64);
            this.lbl_em_name.TabIndex = 11;
            this.lbl_em_name.Text = "Mr/Ms";
            this.lbl_em_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_logout.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_logout.BorderRadius = 0;
            this.btn_logout.BorderSize = 0;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(8, 548);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(259, 63);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextColor = System.Drawing.Color.White;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(-5, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 2);
            this.panel2.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_revenue);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.btn_by_month);
            this.Controls.Add(this.btn_all_the_time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.ptb_em_pic);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_em_pic)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.pnl_UserName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Label lbl_title;
        private View.CustomPictureBox ptb_em_pic;
        private View.CustomPanel customPanel1;
        private System.Windows.Forms.Panel pnl_UserName;
        private System.Windows.Forms.Label lbl_em_name;
        private View.CustomButton btn_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.ComboBox cbb_month;
        private View.CustomButton btn_by_month;
        private View.CustomButton btn_all_the_time;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
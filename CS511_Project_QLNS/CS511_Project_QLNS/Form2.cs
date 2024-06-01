﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Documents;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using LiveCharts.WinForms;

namespace CS511_Project_QLNS
{
    public partial class Form2 : Form
    {
        connection co = new connection();
        public System.Drawing.Color color_btn_normal = System.Drawing.Color.FromArgb(24, 138, 93);
        public System.Drawing.Color color_btn_chosen = System.Drawing.Color.FromArgb(31, 181, 122);

        Uct_Employee_Home uct_Employee_Home;
        Uct_Employee_Import uct_Employee_Import;
        Uct_Employee_Report uct_Employee_Report;
        Uct_Employee_Chat uct_Employee_Chat;
        Uct_Employee_Cashier uct_Employee_Cashier;

        //report
        string connect;

        public SqlConnection sqlCon;
        public string local_dir;

        public System.Drawing.Color color_btn_cate_normal = System.Drawing.Color.Green;
        public System.Drawing.Color color_btn_cate_chosen = System.Drawing.Color.FromArgb(0, 181, 0);

        public int is_displayed_button;

        List<String> list = new List<String>();
        ChartValues<decimal> decimals = new ChartValues<decimal>();

        string[] a = new string[200];
        int[] b = new int[200];
        int count;

        //emp info
        public int emp_id;
        public int is_manager;

        public Image emp_img
        {
            get { return ptb_em_pic.BackgroundImage; }
            set { ptb_em_pic.BackgroundImage = value; }
        }
        public string emp_name
        {
            get { return lbl_em_name.Text; }
            set { lbl_em_name.Text = value; }
        }
        public Form2(int id)
        {
            InitializeComponent();
            //Uct_Employee_Home uct = new Uct_Employee_Home();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);
            //Uct_Employee_Import uct = new Uct_Employee_Import();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //Uct_Employee_Report uct = new Uct_Employee_Report();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //Uct_Employee_Cashier uct = new Uct_Employee_Cashier();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //if manager -> show employee, not -> don't show

            emp_id = id;

            LoadEmpInfo();
            if (is_manager == 1)
            {
                btn_employee.Visible = true;
            }
            else
            {
                btn_employee.Visible = false;
            }

            uct_Employee_Home = new Uct_Employee_Home();
            uct_Employee_Home.Location = new System.Drawing.Point(315, 130);
            uct_Employee_Home.Name = "uct_Employee_Home";
            this.Controls.Add(uct_Employee_Home);
            uct_Employee_Home.BringToFront();

        }
        public void LoadEmpInfo()
        {
            SqlConnection sqlCon;
            SqlCommand cmd;
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_em_name.Text = dr.GetString(2);
                ptb_em_pic.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + emp_id + ".png");
                is_manager = int.Parse(dr.GetString(5));
            }
            sqlCon.Close();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.BackgroundImage = Properties.Resources.Cross3_Img;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackgroundImage = Properties.Resources.Cross2_image;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "HOME";

            btn_home.BackColor = color_btn_chosen;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_normal;

            Uct_Employee_Home ctr = FindControlByName(this, "uct_Employee_Home") as Uct_Employee_Home;
            if (ctr != null)
            {
                ctr.DisposePictureBoxImages();
                //this.Controls.Remove(ctr);
            }

            uct_Employee_Home = new Uct_Employee_Home();
            uct_Employee_Home.Location = new System.Drawing.Point(315, 130);
            uct_Employee_Home.Name = "uct_Employee_Home";
            this.Controls.Add(uct_Employee_Home);
            uct_Employee_Home.BringToFront();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "IMPORT";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_chosen;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_normal;

            uct_Employee_Import = new Uct_Employee_Import();
            uct_Employee_Import.Location = new System.Drawing.Point(315, 130);
            uct_Employee_Import.Name = "uct_Employee_Import";
            this.Controls.Add(uct_Employee_Import);
            uct_Employee_Import.BringToFront();
        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "REPORT";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_chosen;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_normal;

            //uct_Employee_Report = new Uct_Employee_Report();
            //uct_Employee_Report.Location = new System.Drawing.Point(235, 105);
            //uct_Employee_Report.Name = "uct_Employee_Report";
            //this.Controls.Add(uct_Employee_Report);
            //uct_Employee_Report.BringToFront();

            //pnl_report.BringToFront();
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1 is Uct_Employee_Home)
                {
                    ctr1.Visible = false;
                }
            }
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1 is Uct_Employee_Import)
                {
                    ctr1.Visible = false;
                }
            }
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1 is Uct_Employee_Chat)
                {
                    ctr1.Visible = false;
                }
            }
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1 is Uct_Employee_Cashier)
                {
                    ctr1.Visible = false;
                }
            }

            btn_all_the_time.BackColor = color_btn_cate_chosen;
            btn_by_month.BackColor = color_btn_cate_normal;

            cbb_month.Visible = false;
            LoadDataReportChartA();
            LoadDataPieChartA();
            LoadChart();
            LoadPieChart();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "CHAT";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_chosen;
            btn_employee.BackColor = color_btn_normal;

            uct_Employee_Chat = new Uct_Employee_Chat();
            uct_Employee_Chat.Location = new System.Drawing.Point(315, 130);
            uct_Employee_Chat.Name = "uct_Employee_Chat";
            this.Controls.Add(uct_Employee_Chat);
            uct_Employee_Chat.BringToFront();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "EMPLOYEE";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_chosen;

            Uct_Employee_Cashier ctr = FindControlByName(this, "uct_Employee_Cashier") as Uct_Employee_Cashier;
            if (ctr != null)
            {
                ctr.DisposeUserControlPictures();
                //this.Controls.Remove(ctr);
            }

            uct_Employee_Cashier = new Uct_Employee_Cashier();
            uct_Employee_Cashier.Location = new System.Drawing.Point(315, 130);
            uct_Employee_Cashier.Name = "uct_Employee_Cashier";
            this.Controls.Add(uct_Employee_Cashier);
            uct_Employee_Cashier.BringToFront();
        }

        Control FindControlByName(Control control, string controlName)
        {
            if (control.Name == controlName)
            {
                return control;
            }

            foreach (Control childControl in control.Controls)
            {
                Control foundControl = FindControlByName(childControl, controlName);
                if (foundControl != null)
                {
                    return foundControl;
                }
            }
            return null;
        }

        public void LoadDataReportChartA()
        {
            list.Clear();
            decimals.Clear();
            SqlCommand cmd = new SqlCommand();
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MONTH(C_DATE) AS MONTH, YEAR(C_DATE) AS YEAR, SUM(TOTAL) AS TOTAL FROM TBL_CUS_RECEIPT GROUP BY MONTH(C_DATE), YEAR(C_DATE)";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int month = dr.GetInt32(0);
                int year = dr.GetInt32(1);
                list.Add(month + "/" + year);
                decimals.Add(dr.GetDecimal(2));
            }
            dr.Close();
            sqlCon.Close();
        }
        public void LoadDataPieChartA()
        {
            count = 0;
            a = new string[200];
            b = new int[200];
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 5 TBL_REC_DETAIL.BOOK_NAME ,SUM(TBL_REC_DETAIL.QUANTITY) FROM TBL_REC_DETAIL GROUP BY TBL_REC_DETAIL.BOOK_NAME, TBL_REC_DETAIL.ID_BOOK ORDER BY SUM(TBL_REC_DETAIL.QUANTITY) DESC";
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                a[count] = dr2.GetString(0);
                b[count] = dr2.GetInt32(1);
                count++;
            }
            dr2.Close();
            sqlCon.Close();
        }

        public void LoadChart()
        {
            chart.AxisX.Clear();
            chart.AxisY.Clear();
            chart.Series.Clear();
            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = list

            });
            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString()
            });
            var revenueSeries = new LineSeries
            {
                Title = "Revenue",
                Values = decimals, //new ChartValues<double> { 1222 },
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 139, 34)), // Setting the line color to ForestGreen
                //Fill = System.Windows.Media.Brushes.Transparent // Setting the fill to transparent
            };
            chart.AnimationsSpeed = TimeSpan.FromMilliseconds(200);
            chart.Series.Add(revenueSeries);
        }

        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        public void LoadPieChart()
        {
            SeriesCollection series = new SeriesCollection();
            for (int i = 0; i < 5; i++)
            {
                series.Add(new PieSeries(i) { Title = a[i], Values = new ChartValues<int> { b[i] }, DataLabels = true, LabelPoint = label });

            }
            piechart.AnimationsSpeed = TimeSpan.FromMilliseconds(200);
            piechart.Series = series;
        }
    }
}

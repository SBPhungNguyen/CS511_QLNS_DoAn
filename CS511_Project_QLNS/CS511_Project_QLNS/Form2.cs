using System;
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
using System.Windows.Forms.DataVisualization.Charting;

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

        string[] month = new string[200];
        decimal[] decimalss = new decimal[200];
        int count_2;

        //emp info
        public int emp_id;
        public int is_manager;

        //timer for chatting
        public Timer emp_timer = new Timer();
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
            uct_Employee_Home.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Home.Name = "uct_Employee_Home";
            this.Controls.Add(uct_Employee_Home);
            uct_Employee_Home.BringToFront();

            emp_timer.Interval = 100;
            emp_timer.Start();
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
            uct_Employee_Home.Location = new System.Drawing.Point(235, 105);
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
            uct_Employee_Import.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Import.Name = "uct_Employee_Import";
            this.Controls.Add(uct_Employee_Import);
            uct_Employee_Import.BringToFront();
        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "REPORT";
            lbl_revenue.Text = "Revenue by all months";

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

            is_displayed_button = 0;
            btn_all_the_time.BackColor = color_btn_cate_chosen;
            btn_by_month.BackColor = color_btn_cate_normal;

            cbb_month.Visible = false;
            lbl_month.Visible = false;
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
            uct_Employee_Chat.Location = new System.Drawing.Point(235, 105);
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
            uct_Employee_Cashier.Location = new System.Drawing.Point(235, 105);
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
            //list.Clear();
            //decimals.Clear();
            //SqlCommand cmd = new SqlCommand();
            //sqlCon = new SqlConnection(co.connect);
            //if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            //cmd = new SqlCommand();
            //cmd.Connection = sqlCon;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT MONTH(C_DATE) AS MONTH, YEAR(C_DATE) AS YEAR, SUM(TOTAL) AS TOTAL FROM TBL_CUS_RECEIPT GROUP BY MONTH(C_DATE), YEAR(C_DATE)";
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    int month = dr.GetInt32(0);
            //    int year = dr.GetInt32(1);
            //    list.Add(month + "/" + year);
            //    decimals.Add(dr.GetDecimal(2));
            //}
            //dr.Close();
            //sqlCon.Close();

            SqlCommand cmd = new SqlCommand();
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MONTH(C_DATE) AS MONTH, YEAR(C_DATE) AS YEAR, SUM(TOTAL) AS TOTAL FROM TBL_CUS_RECEIPT GROUP BY MONTH(C_DATE), YEAR(C_DATE)";
            SqlDataReader dr = cmd.ExecuteReader();
            count_2 = 0;
            while (dr.Read())
            {
                int mm = dr.GetInt32(0);
                int year = dr.GetInt32(1);
                month[count_2] = mm + "/" + year;
                decimalss[count_2] = dr.GetDecimal(2);
                count_2++;
            }
            dr.Close();
            sqlCon.Close();
        }
        private void LoadDataReportB()
        {
            //list.Clear();
            //decimals.Clear();
            //string mmyy = cbb_month.Items[cbb_month.SelectedIndex].ToString();
            //string[] split_line = mmyy.Split('/');
            ////MessageBox.Show(mmyy);
            //SqlCommand cmd = new SqlCommand();
            //sqlCon = new SqlConnection(co.connect);
            //if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            //cmd = new SqlCommand();
            //cmd.Connection = sqlCon;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT DAY(C_DATE), SUM(TOTAL) AS TOTAL FROM TBL_CUS_RECEIPT WHERE MONTH(C_DATE) = @mm AND YEAR(C_DATE) = @yy GROUP BY DAY(C_DATE)";
            //cmd.Parameters.AddWithValue("@mm", split_line[0]);
            //cmd.Parameters.AddWithValue("@yy", split_line[1]);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    int date = dr.GetInt32(0);
            //    list.Add(date.ToString() + "/" + split_line[0]);
            //    decimals.Add(dr.GetDecimal(1));
            //}
            //dr.Close();
            //sqlCon.Close();


            string mmyy = cbb_month.Items[cbb_month.SelectedIndex].ToString();
            string[] split_line = mmyy.Split('/');
            //MessageBox.Show(mmyy);
            count_2 = 0;
            SqlCommand cmd = new SqlCommand();
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DAY(C_DATE), SUM(TOTAL) AS TOTAL FROM TBL_CUS_RECEIPT WHERE MONTH(C_DATE) = @mm AND YEAR(C_DATE) = @yy GROUP BY DAY(C_DATE)";
            cmd.Parameters.AddWithValue("@mm", split_line[0]);
            cmd.Parameters.AddWithValue("@yy", split_line[1]);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int date = dr.GetInt32(0);
                month[count_2] = (date.ToString() + "/" + split_line[0]);
                decimalss[count_2] = (dr.GetDecimal(1));
                count_2++;
            }
            dr.Close();
            sqlCon.Close();
        }
        public void LoadDataPieChartA()
        {
            count = 0;
            a = new string[200];
            b = new int[200];
            sqlCon = new SqlConnection(co.connect);
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
        public void LoadDataPieChartB()
        {
            count = 0;
            a = new string[200];
            b = new int[200];
            string mmyy = cbb_month.Items[cbb_month.SelectedIndex].ToString();
            string[] split_line = mmyy.Split('/');
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TOP 5 TBL_REC_DETAIL.BOOK_NAME ,SUM(TBL_REC_DETAIL.QUANTITY) FROM TBL_REC_DETAIL, TBL_CUS_RECEIPT WHERE TBL_REC_DETAIL.ID_REC = TBL_CUS_RECEIPT.ID_REC AND MONTH(TBL_CUS_RECEIPT.C_DATE)=@mm AND YEAR(TBL_CUS_RECEIPT.C_DATE)=@yy GROUP BY TBL_REC_DETAIL.BOOK_NAME, TBL_REC_DETAIL.ID_BOOK ORDER BY SUM(TBL_REC_DETAIL.QUANTITY) DESC";
            cmd.Parameters.AddWithValue("@mm", split_line[0]);
            cmd.Parameters.AddWithValue("@yy", split_line[1]);
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
            // Clear any existing series
            chart1.Series.Clear();

            // Create a new series
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Line
            };

            for(int i = 0; i<count_2;i++)
            {
                series.Points.AddXY(month[i], decimalss[i]);
            }

            // Customize label appearance for each data point
            foreach (DataPoint point in series.Points)
            {
                point.Label = point.YValues[0].ToString();
                point.Font = new Font("Arial", 8f, FontStyle.Bold);
            }

            // Add series to the chart
            chart1.Series.Add(series);

            // Customize the chart appearance
            chart1.ChartAreas[0].AxisX.Title = "Month";
            chart1.ChartAreas[0].AxisY.Title = "Revenue";
            chart1.ChartAreas[0].AxisX.Interval = 1;

            // Customize grid lines to be lighter
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;

            // Optional: Customize legend position
            chart1.Legends[0].Docking = Docking.Bottom;
        }


        public void LoadPieChart()
        {
            chart2.Series.Clear();

            // Create a new series
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Series1",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Doughnut,
            };

            int s = 0;
            for (int i = 0; i<count;i++)
            {
                series.Points.AddXY(a[i], b[i]);
                s = s + b[i];
            }

            // Customize label appearance for each data point
            foreach (DataPoint point in series.Points)
            {
                double percentage = point.YValues[0] / series.Points.FindMaxByValue().YValues[0] * 100;
                point.Label = string.Format("{0}: {1} ({2:P1})", point.AxisLabel, point.YValues[0], point.YValues[0] / s);
                point.Font = new Font("Arial", 8f, FontStyle.Regular);
            }

            // Add series to the chart
            chart2.Series.Add(series);

            // Customize the chart appearance
            chart2.ChartAreas[0].Area3DStyle.Enable3D = false;  // Disable 3D effect
            chart2.Legends[0].Enabled = true;
            chart2.Legends[0].Docking = Docking.Bottom;

        }

        private void btn_all_the_time_Click(object sender, EventArgs e)
        {
            if (is_displayed_button == 0)
                return;
            is_displayed_button = 0;
            btn_all_the_time.BackColor = color_btn_cate_chosen;
            btn_by_month.BackColor = color_btn_cate_normal;
            lbl_revenue.Text = "Revenue by all months";

            cbb_month.Visible = false;
            lbl_month.Visible = false;

            chart1.Series.Clear();
            chart2.Series.Clear();
            LoadDataReportChartA();
            LoadChart();

            LoadDataPieChartA();
            LoadPieChart();
        }

        private void LoadMonthForCBBChart()
        {
            cbb_month.Items.Clear();
            if (sqlCon.State == ConnectionState.Closed) {  sqlCon.Open(); }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT MONTH(C_DATE), YEAR(C_DATE) FROM TBL_CUS_RECEIPT";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string mmyy = dr.GetInt32(0)+"/"+dr.GetInt32(1);
                cbb_month.Items.Add(mmyy);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void btn_by_month_Click(object sender, EventArgs e)
        {
            if (is_displayed_button == 1)
                return;
            is_displayed_button = 1;
            btn_all_the_time.BackColor = color_btn_cate_normal;
            btn_by_month.BackColor = color_btn_cate_chosen;

            cbb_month.Visible = true;
            lbl_month.Visible = true;
            LoadMonthForCBBChart();
            cbb_month.SelectedIndex = cbb_month.Items.Count - 1;
            lbl_revenue.Text = "Revenue by " + cbb_month.Items[cbb_month.SelectedIndex];

            chart1.Series.Clear();
            chart2.Series.Clear();
            LoadDataReportB();
            LoadChart();
            LoadDataPieChartB();
            LoadPieChart();
        }

        private void cbb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_revenue.Text = "Revenue by " + cbb_month.Items[cbb_month.SelectedIndex];
            is_displayed_button = 1;
            chart1.Series.Clear();
            chart2.Series.Clear();
            LoadDataReportB();
            LoadChart();
            LoadDataPieChartB();
            LoadPieChart();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            emp_timer.Stop();
            ptb_em_pic.Dispose();
            Uct_Employee_Home uct1 = FindControlByName(this,"uct_Employee_Home") as Uct_Employee_Home;
            if (uct1 != null)
                uct1.DisposePictureBoxImages();
            Uct_Employee_Cashier uct2 = FindControlByName(this, "uct_Employee_Cashier") as Uct_Employee_Cashier;
            if (uct2 != null)
                uct2.DisposeUserControlPictures();
            this.Dispose();
            this.Close();

        }
    }
}

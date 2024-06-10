using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace CS511_Project_QLNS
{
    public partial class Uct_Employee_Report : UserControl
    {
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

        connection co = new connection();
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand cmd;

        public Uct_Employee_Report()
        {
            InitializeComponent();

            lbl_revenue.Text = "Revenue by all months";

            sqlCon = new SqlConnection(co.connect);

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

            for (int i = 0; i < count_2; i++)
            {
                series.Points.AddXY(month[i], decimalss[i]);
            }

            // Customize label appearance for each data point
            foreach (DataPoint point in series.Points)
            {
                point.Label = point.YValues[0].ToString();
                point.Font = new Font("Arial", 14f, FontStyle.Bold);
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
            for (int i = 0; i < count; i++)
            {
                series.Points.AddXY(a[i], b[i]);
                s = s + b[i];
            }

            // Customize label appearance for each data point
            foreach (DataPoint point in series.Points)
            {
                double percentage = point.YValues[0] / series.Points.FindMaxByValue().YValues[0] * 100;
                point.Label = string.Format("{0}: {1} ({2:P1})", point.AxisLabel, point.YValues[0], point.YValues[0] / s);
                point.Font = new Font("Arial", 11f, FontStyle.Regular);
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
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT MONTH(C_DATE), YEAR(C_DATE) FROM TBL_CUS_RECEIPT";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string mmyy = dr.GetInt32(0) + "/" + dr.GetInt32(1);
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
    }
}

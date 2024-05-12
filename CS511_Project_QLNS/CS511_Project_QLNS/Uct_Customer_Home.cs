using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Customer_Home : UserControl
    {
        connection con = new connection();
        string connect;

        public SqlConnection sqlCon;
        public string local_dir = "Pic/";

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        public Uct_Customer_Home()
        {
            InitializeComponent();
            fpnl_books.WrapContents = true; 
            fpnl_books.AutoScroll = true;

            cbb_type.SelectedIndex = 0;


            //establish the sqlCon for db
            connect = con.connect;
            sqlCon = new SqlConnection(connect);

            btn_all.BackColor = color_btn_cate_chosen;
            LoadData();

        }

        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from TBL_BOOK";

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

                uct_Cus_Book.LoadData(rd.GetInt32(0),img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"));
                fpnl_books.Controls.Add(uct_Cus_Book);
            }

            sqlCon.Close();
        }

        public void LoadDataWithCate(string cate)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from TBL_BOOK WHERE GENRE = "+cate;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"));
                fpnl_books.Controls.Add(uct_Cus_Book);
            }

            sqlCon.Close();
        }


        //Clear the flow panel before loading new ele
        private void ClearFlowPanel()
        {
            fpnl_books.SuspendLayout();

            if (fpnl_books.Controls.Count > 0)
            {
                for (int i = (fpnl_books.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = fpnl_books.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            fpnl_books.ResumeLayout();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_chosen;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
            btn_cat3.BackColor = color_btn_cate_normal;
            btn_cat4.BackColor = color_btn_cate_normal;
            btn_cat5.BackColor = color_btn_cate_normal;
            btn_cat6.BackColor = color_btn_cate_normal;

            LoadData();
        }

        private void btn_cat1_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_chosen;
            btn_cat2.BackColor = color_btn_cate_normal;
            btn_cat3.BackColor = color_btn_cate_normal;
            btn_cat4.BackColor = color_btn_cate_normal;
            btn_cat5.BackColor = color_btn_cate_normal;
            btn_cat6.BackColor = color_btn_cate_normal;

            LoadDataWithCate("1");

        }


        private void btn_cat2_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_chosen;
            btn_cat3.BackColor = color_btn_cate_normal;
            btn_cat4.BackColor = color_btn_cate_normal;
            btn_cat5.BackColor = color_btn_cate_normal;
            btn_cat6.BackColor = color_btn_cate_normal;

            LoadDataWithCate("2");
        }

        private void btn_cat3_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
            btn_cat3.BackColor = color_btn_cate_chosen;
            btn_cat4.BackColor = color_btn_cate_normal;
            btn_cat5.BackColor = color_btn_cate_normal;
            btn_cat6.BackColor = color_btn_cate_normal;

            LoadDataWithCate("3");
        }

        private void btn_cat4_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
            btn_cat3.BackColor = color_btn_cate_normal;
            btn_cat4.BackColor = color_btn_cate_chosen;
            btn_cat5.BackColor = color_btn_cate_normal;
            btn_cat6.BackColor = color_btn_cate_normal;

            LoadDataWithCate("4");
        }

        private void btn_cat5_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
            btn_cat3.BackColor = color_btn_cate_normal;
            btn_cat4.BackColor = color_btn_cate_normal;
            btn_cat5.BackColor = color_btn_cate_chosen;
            btn_cat6.BackColor = color_btn_cate_normal;

            LoadDataWithCate("5");
        }

        private void btn_cat6_Click(object sender, EventArgs e)
        {
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
            btn_cat3.BackColor = color_btn_cate_normal;
            btn_cat4.BackColor = color_btn_cate_normal;
            btn_cat5.BackColor = color_btn_cate_normal;
            btn_cat6.BackColor = color_btn_cate_chosen;

            LoadDataWithCate("6");
        }
    }
}

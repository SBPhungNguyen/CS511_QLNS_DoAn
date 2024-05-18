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
using ZXing.OneD;

namespace CS511_Project_QLNS
{
    public partial class Uct_Employee_Home : UserControl
    {
        connection co = new connection();
        string connect;
        string local_dir;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        public int is_displayed_button;
        public Uct_Employee_Home()
        {
            InitializeComponent();
            fpnl_books.WrapContents = true;
            fpnl_books.AutoScroll = true;

            connect = co.connect;
            local_dir = co.local_dir;

            sqlCon = new SqlConnection(connect);

            is_displayed_button = 0;
            btn_all.BackColor = color_btn_cate_chosen;

            cbb_type.SelectedIndex = 0;

            LoadData(); 
        }

        public void LoadData()
        {
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK";

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(local_dir + dr.GetString(1) + ".png");
                Uct_Emp_Book book = new Uct_Emp_Book();
                book.LoadData(dr.GetInt32(0),img,dr.GetString(2), dr.GetString(3));
                fpnl_books.Controls.Add(book);
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
        public void LoadDataWithCate(string cate)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from TBL_BOOK WHERE GENRE = " + cate;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
                fpnl_books.Controls.Add(uct_Cus_Book);
            }

            sqlCon.Close();
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

            is_displayed_button = 0;
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

            is_displayed_button = 1;
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

            is_displayed_button = 2;
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

            is_displayed_button = 3;
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

            is_displayed_button = 4;
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

            is_displayed_button = 5;
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

            is_displayed_button = 6;
            LoadDataWithCate("6");
        }
    }
}

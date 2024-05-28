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
    public partial class Uct_Employee_Cashier : UserControl
    {
        connection co = new connection();
        public string connect;
        public string pic_dir;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        public int is_displayed_button;
        public Uct_Employee_Cashier()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            pic_dir = co.emp_dir;

            is_displayed_button = 0;
            btn_all.BackColor = color_btn_cate_chosen;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;

            cbb_type.SelectedIndex = 0;

            LoadData();
        }
        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Uct_Emp_Cashier uct = new Uct_Emp_Cashier();
                Image img = System.Drawing.Image.FromFile( pic_dir + dr.GetString(1)+".png");
                uct.LoadData(dr.GetInt32(0), img, dr.GetString(2), dr.GetString(5));
                fpnl_emp.Controls.Add(uct);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            if (is_displayed_button == 0)
                return;
            is_displayed_button = 0;
            btn_all.BackColor = color_btn_cate_chosen;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
        }

        private void btn_cat1_Click(object sender, EventArgs e)
        {
            if (is_displayed_button == 1)
                return;
            is_displayed_button = 1;
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_chosen;
            btn_cat2.BackColor = color_btn_cate_normal;

        }

        private void btn_cat2_Click(object sender, EventArgs e)
        {
            if (is_displayed_button == 2)
                return;
            is_displayed_button = 2;
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_chosen;
        }
    }
}

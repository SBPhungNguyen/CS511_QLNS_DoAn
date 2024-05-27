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
    public partial class Emp_ImportInfo : Form
    {
        string id;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Emp_ImportInfo(string id)
        {
            InitializeComponent();
            this.id = id;
            sqlCon = new SqlConnection(co.connect);

            LoadData();
        }
        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }  

            //this is to load the receipt general info
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP_IMPORT WHERE ID = "+id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_code.Text = dr.GetInt32(0).ToString();
                string[] split_line = dr.GetDateTime(1).ToString().Split(' ');
                lbl_date.Text = split_line[0];
                lbl_em_name.Text = dr.GetString(3);
                lbl_total.Text = string.Format("{0:#,###}", int.Parse(dr.GetDecimal(4).ToString("0.##")));
            }
            dr.Close();

            //this is to load the detail info
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_IMP_DETAIL WHERE ID_IMP = " + id;
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                Uct_Emp_Detail imp_detail = new Uct_Emp_Detail();
                imp_detail.LoadData(dr2.GetInt32(1), dr2.GetString(2), string.Format("{0:#,###}", int.Parse(dr2.GetDecimal(3).ToString("0.##"))), dr2.GetInt32(4).ToString(), string.Format("{0:#,###}", int.Parse(dr2.GetDecimal(5).ToString("0.##"))));
                fpnl_detail.Controls.Add(imp_detail);

            }
            dr2.Close();
            sqlCon.Close();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.BackgroundImage = Properties.Resources.Cross3_Img;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackgroundImage = Properties.Resources.Cross2_image;
        }
    }
}

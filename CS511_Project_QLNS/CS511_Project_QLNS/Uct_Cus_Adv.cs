using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Cus_Adv : UserControl
    {
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Cus_Adv()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            LoadData();
        }
        public void LoadData()
        {
            ptb_bigimg.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "c.png");
            ptb_smallimg1.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "a.png");
            ptb_smallimg2.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "b.png");
        }

        private void ptb_bigimg_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_ADV WHERE AD_NAME = 'c'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Process.Start(dr.GetString(1));
            }
            dr.Close();
            sqlCon.Close();

        }

        private void ptb_smallimg1_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_ADV WHERE AD_NAME = 'a'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Process.Start(dr.GetString(1));
            }
            dr.Close();
            sqlCon.Close();
        }

        private void ptb_smallimg2_Click(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_ADV WHERE AD_NAME = 'b'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Process.Start(dr.GetString(1));
            }
            dr.Close();
            sqlCon.Close();
        }
        public void DisposePic()
        {
            ptb_bigimg.BackgroundImage.Dispose();
            ptb_smallimg1.BackgroundImage.Dispose();
            ptb_smallimg2.BackgroundImage.Dispose();
        }
    }
}

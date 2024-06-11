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
    public partial class Uct_Cus_HomeInfo : UserControl
    {
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Cus_HomeInfo()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            LoadData();
        }
        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOKSTORE_INFO";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_name.Text = dr.GetString(1);
                lbl_quote.Text = dr.GetString(2);
                lbl_location.Text = dr.GetString(3);
                lbl_mail.Text = dr.GetString(4);
                lbl_phone.Text = dr.GetString(5);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_location.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_mail.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_phone.Text);
        }
    }
}

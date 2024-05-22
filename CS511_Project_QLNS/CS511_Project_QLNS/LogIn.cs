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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
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

        private void btn_guest_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();

            this.Show();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon;
            SqlCommand cmd;
            connection co = new connection();
            sqlCon = new SqlConnection(co.connect);
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID, E_NAME, PWORD FROM TBL_EMP";
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if (dr.GetString(1) == txt_name.Texts && dr.GetString(2) == txt_pass.Texts)
                {
                    Form2 form = new Form2(dr.GetInt32(0));
                    this.Hide();
                    form.ShowDialog();

                    this.Show();
                }
            }


        }
    }
}

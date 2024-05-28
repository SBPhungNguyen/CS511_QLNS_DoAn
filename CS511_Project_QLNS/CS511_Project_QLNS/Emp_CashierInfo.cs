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
    public partial class Emp_CashierInfo : Form
    {
        public int id;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        string pic_dir;
        string pass;
        int state_show; //0: not show pass, 1: show pass
        public Emp_CashierInfo(int id)
        {
            InitializeComponent();
            this.id = id;   
            sqlCon = new SqlConnection(co.connect);
            pic_dir =co.emp_dir;
            state_show = 0;
            LoadData();
        }
        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TBL_EMP WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", id.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(pic_dir + dr.GetString(1) + ".png");
                lbl_id.Text = id.ToString();
                lbl_name.Text = dr.GetString(2);
                lbl_phone.Text = dr.GetString(3);
                string[] split_line = dr.GetDateTime(4).ToString().Split(' ');
                lbl_bday.Text = split_line[0];
                if (dr.GetString(5) == "0")
                    lbl_role.Text = "Cashier";
                else
                    lbl_role.Text = "Manager";
                pass = dr.GetString(6);

                lbl_pword.Text = "";
                int count_pass = pass.Count();
                for (int i = 0; i < count_pass; i++)
                {
                    lbl_pword.Text = lbl_pword.Text + "●";
                }

            }
            dr.Close();
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

        private void ptb_hidden_Click(object sender, EventArgs e)
        {
            if (state_show==0)
            {
                ptb_hidden.BackgroundImage = Properties.Resources.icon_eye_open;
                lbl_pword.Text = pass;
                state_show = 1;
            }
            else
            {
                ptb_hidden.BackgroundImage = Properties.Resources.icon_eye_close;
                int count_pass = pass.Count();
                lbl_pword.Text = "";
                for (int i = 0; i < count_pass; i++)
                {
                    lbl_pword.Text = lbl_pword.Text + "●";
                }
                state_show =0;
            }
        }
    }
}

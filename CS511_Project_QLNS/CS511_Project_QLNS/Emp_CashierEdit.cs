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
    public partial class Emp_CashierEdit : Form
    {
        int id;
        SqlConnection sqlCon;
        SqlCommand cmd;
        connection co = new connection();
        int is_state;   //0: invisible, 1:visible
        string pass;
        public string b_date
        {
            get { return txt_bday.Texts; }
            set { txt_bday.Texts = value; }
        }
        public Emp_CashierEdit(int id)
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            this.id = id;
            is_state = 0;
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
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_id.Text = id.ToString();
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + dr.GetString(1)+".png");
                txt_name.Texts = dr.GetString(2);
                txt_phone.Texts = dr.GetString(3);
                string[] split_line = dr.GetDateTime(4).ToString().Split(' ');
                txt_bday.Texts = split_line[0];
                if (dr.GetString(5) == "0")
                    radio_cashier.Checked = true;
                else
                    radio_manager.Checked = true;
                pass = dr.GetString(6);
                txt_pass.Texts = "";
                int count_pass = pass.Count();
                for (int i = 0; i < count_pass; i++)
                {
                    txt_pass.Texts = txt_pass.Texts + "●";
                }
            }
            dr.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ptb_img.Dispose();
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

        private void txt_bday_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ptb_hidden_Click(object sender, EventArgs e)
        {
            if (is_state == 0)
            {
                ptb_hidden.BackgroundImage = Properties.Resources.icon_eye_open;
                is_state = 1;
                txt_pass.Texts = pass;
            }
            else
            {
                pass = txt_pass.Texts;
                is_state = 0;
                ptb_hidden.BackgroundImage = Properties.Resources.icon_eye_close;
                int count_pass = pass.Count();
                txt_pass.Texts = "";
                for (int i = 0; i < count_pass; i++)
                {
                    txt_pass.Texts = txt_pass.Texts + "●";
                }
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (is_state ==0)
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}

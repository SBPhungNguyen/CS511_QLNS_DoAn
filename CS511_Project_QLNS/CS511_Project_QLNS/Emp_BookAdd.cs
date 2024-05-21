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
    public partial class Emp_BookAdd : Form
    {
        Form2 parent_form;
        connection co =new connection();
        string connect;
        SqlConnection sqlCon;
        SqlCommand cmd;
        int id;

        public Emp_BookAdd(Form2 parent)
        {
            InitializeComponent();
            parent_form = parent;

            cbb_type.SelectedIndex = 0;

            connect = co.connect;
            sqlCon = new SqlConnection(connect);
            if (sqlCon.State == ConnectionState.Closed )
            {
                sqlCon.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MAX(ID) FROM TBL_BOOK";
            int max = (int)cmd.ExecuteScalar();
            id = max + 1;
            lbl_id.Text = id.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ptb_img.BackgroundImage.Dispose();
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

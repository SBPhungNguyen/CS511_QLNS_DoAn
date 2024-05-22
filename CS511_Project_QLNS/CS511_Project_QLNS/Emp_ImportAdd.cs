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
    public partial class Emp_ImportAdd : Form
    {
        Form2 parent_form;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;

        public Emp_ImportAdd(Form2 form)
        {
            InitializeComponent();
            fpnl_detail.AutoScroll = true;
            fpnl_detail.WrapContents = true;

            lbl_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            
            //get emp info
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed ) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP";

            parent_form = form;

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

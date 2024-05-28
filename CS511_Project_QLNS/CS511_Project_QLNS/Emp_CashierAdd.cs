using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Emp_CashierAdd : Form
    {
        FileInfo file;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        string pic_dir;
        int role_index;
        public string b_date
        {
            get { return txt_bday.Texts; }
            set { txt_bday.Texts = value;}
        }
        public Emp_CashierAdd()
        {
            InitializeComponent();
            file = new FileInfo("icon_picture.png");
            sqlCon = new SqlConnection(co.connect);
            pic_dir = co.emp_dir;

            role_index = 0;
            radio_cashier.Checked = true;
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

        private void ptb_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Picture (.png) | *.png";
            dlg.Multiselect = false;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(dlg.FileName);
                file = new FileInfo(dlg.FileName);
            }
        }

        private void radio_cashier_CheckedChanged(object sender, EventArgs e)
        {
            if (role_index == 1)
            {
                role_index = 0;
                radio_manager.Checked = false;
                radio_cashier.Checked = true;
            }
        }

        private void radio_manager_CheckedChanged(object sender, EventArgs e)
        {
            if (role_index == 0)
            {
                role_index = 1;
                radio_cashier.Checked = false;
                radio_manager.Checked = true;
            }
        }

        private void txt_bday_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void ptb_hidden_Click(object sender, EventArgs e)
        {
            CalendarShow calendar = new CalendarShow(this);
            calendar.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Texts =="" || txt_bday.Texts =="" || txt_pass.Texts == ""||txt_phone.Texts =="")
            {
                MessageBox.Show("Please fill out all the blanks", "Opps");
                return;
            }
            else
            {

            }
        }
    }
}

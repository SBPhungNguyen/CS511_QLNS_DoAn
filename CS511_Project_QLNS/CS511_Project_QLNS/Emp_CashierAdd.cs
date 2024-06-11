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
            ptb_img.BackgroundImage.Dispose();
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
                //check if the imput strings were numbers
                string inputString = txt_phone.Texts.Trim();
                long outputValue;

                // TryParse returns true if conversion is successful and assigns the value to outputValue
                bool isLong = long.TryParse(inputString, out outputValue);

                if (!isLong || outputValue < 0)
                {
                    // The string is a valid long
                    MessageBox.Show($"The string '{inputString}' in Phone is not valid");
                    return;
                }

                //open sqlCon
                if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }

                //add emp info into TBL_EMP (except for the pic)
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO TBL_EMP (E_NAME,PHONE,BDAY,E_ROLE,PWORD) VALUES(@name, @phone, @bday, @e_role, @pword)";
                cmd.Parameters.AddWithValue("@name",txt_name.Texts);
                cmd.Parameters.AddWithValue("@phone",txt_phone.Texts);
                cmd.Parameters.AddWithValue("@bday",txt_bday.Texts);
                cmd.Parameters.AddWithValue("@e_role", role_index);
                cmd.Parameters.AddWithValue("@pword",txt_pass.Texts);
                cmd.ExecuteNonQuery();

                int id;
                //get the nearest ID of the emp int TBL_EMP
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT MAX(ID) FROM TBL_EMP";
                id = (int)cmd.ExecuteScalar();

                //copy pic to desired dir
                file.CopyTo(pic_dir + id + ".png", true);

                //update pic to TBL_EMP
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE TBL_EMP SET PIC = @pic WHERE ID = @id";
                cmd.Parameters.AddWithValue("@pic", id);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added successfully", "Notification");

                //close connection
                sqlCon.Close();

                btn_exit_Click(sender, e);
            }
        }
    }
}

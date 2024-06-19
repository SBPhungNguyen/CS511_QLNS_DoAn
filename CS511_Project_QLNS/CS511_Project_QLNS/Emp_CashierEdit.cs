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
    public partial class Emp_CashierEdit : Form
    {
        int id;
        SqlConnection sqlCon;
        SqlCommand cmd;
        connection co = new connection();
        int is_state;   //0: invisible, 1:visible
        string pass;
        string pic_dir;
        FileInfo fileInfo = null;
        string pic_path;
        int is_manager;

        Form2 parent;
        Image img;

        public string b_date
        {
            get { return txt_bday.Texts; }
            set { txt_bday.Texts = value; }
        }
        public Emp_CashierEdit(int id, Form2 form)
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            this.id = id;
            is_state = 0;
            pic_dir = co.emp_dir;
            parent = form;
            ptb_img.BackgroundImage.Dispose();
            fileInfo = null;
            pic_path = null;
            LoadData();
        }
        public void LoadData()
        {
            if (parent.emp_id == this.id)
                parent.emp_img.Dispose();

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
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + dr.GetString(1) + ".png");
                
                txt_name.Texts = dr.GetString(2);
                txt_phone.Texts = dr.GetString(3);
                string[] split_line = dr.GetDateTime(4).ToString().Split(' ');
                txt_bday.Texts = split_line[0];
                if (dr.GetString(5) == "0")
                    radio_cashier.Checked = true;
                else
                    radio_manager.Checked = true;
                is_manager = int.Parse(dr.GetString(5));
                pass = dr.GetString(6);
                txt_pass.Texts = "";
                int count_pass = pass.Count();
                for (int i = 0; i < count_pass; i++)
                {
                    txt_pass.Texts = txt_pass.Texts + "●";
                }
            }
            dr.Close();
            sqlCon.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ptb_img.BackgroundImage.Dispose();
            parent.emp_img.Dispose();
            parent.emp_img = System.Drawing.Image.FromFile(co.emp_dir + parent.emp_id + ".png");
            if (this.id == parent.emp_id)
                parent.emp_name = txt_name.Texts;
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
            {
                e.Handled = false;
                //pass = txt_pass.Texts;
            }
        }

        private void ptb_calendar_Click(object sender, EventArgs e)
        {
            CalendarShow calendar = new CalendarShow(this);
            calendar.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_exit_Click(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Texts == "" || txt_bday.Texts == "" || txt_pass.Texts == "" || txt_phone.Texts == "")
            {
                MessageBox.Show("Please fill out all the blanks", "Cannot update");
                return;
            }

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

            //edit the emp detail in TBL_EMP
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();

            ptb_img.BackgroundImage.Dispose();

            if (is_state == 1)
            {
                pass = txt_pass.Texts;
            }

            //add code here to save the pic to the desired dir
            if (pic_path != null)
            { 
                fileInfo = new FileInfo(pic_path);
                fileInfo.CopyTo(pic_dir + lbl_id.Text + ".png", true);
            }

            //MessageBox.Show(pass);

            //update book info in table TBL_BOOK
            cmd.CommandText = "UPDATE TBL_EMP SET E_NAME = @name, PHONE = @phone, BDAY = @bday, E_ROLE = @role, PWORD = @pass WHERE ID = " + lbl_id.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", txt_name.Texts);
            cmd.Parameters.AddWithValue("@phone", txt_phone.Texts);
            cmd.Parameters.AddWithValue("@bday", txt_bday.Texts);
            cmd.Parameters.AddWithValue("@role", is_manager);
            cmd.Parameters.AddWithValue("@pass", pass.ToString());
            cmd.ExecuteNonQuery();


            //Update book info in table TBL_EMP_IMPORT
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE TBL_EMP_IMPORT SET EMP_NAME = @name WHERE EMP_ID = " + lbl_id.Text;
            cmd.Parameters.AddWithValue("@name", txt_name.Texts);
            cmd.ExecuteNonQuery();

            pic_path = null;
            fileInfo = null;

            sqlCon.Close();
            MessageBox.Show("This has been updated", "Notification");
            
        }

        private void ptb_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Picture (.png) | *.png";
            dlg.Multiselect = false;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptb_img.BackgroundImage.Dispose();
                parent.emp_img.Dispose();

                if (dlg.FileName.Contains(lbl_id.Text + ".png") && dlg.FileName.Contains(pic_dir))
                {
                    MessageBox.Show("The picture you chose was the same one with the previous", "Opps");
                    return;
                }
                if (dlg.FileName.Contains("new_emp_pic.png"))
                {
                    MessageBox.Show("This picture cannot be chosen, please choose another one", "Opps");
                    return;
                }

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(dlg.FileName);

                FileInfo file = new FileInfo(dlg.FileName);
                file.CopyTo("new_emp_pic.png", true);
                pic_path = "new_emp_pic.png";
            }
        }

        private void radio_cashier_CheckedChanged(object sender, EventArgs e)
        {
            if (is_manager == 0)
                return;
            is_manager = 0;
            radio_cashier.Checked = true;
        }

        private void radio_manager_CheckedChanged(object sender, EventArgs e)
        {
            if (is_manager == 1)
                return;
            is_manager = 1;
            radio_manager.Checked = true;
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (is_state == 0)
                e.Handled = true;
            else
            {
                e.Handled = false;
            }
        }
    }
}

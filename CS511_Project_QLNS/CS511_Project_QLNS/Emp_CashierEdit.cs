﻿using System;
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
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + dr.GetString(1)+".png");
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
            
            //edit the emp detail in TBL_EMP
            if (sqlCon.State != ConnectionState.Open)
                sqlCon.Open();
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();

            //add code here to save the pic to the desired dir
            if (pic_path != null)
            {
                FileInfo file = new FileInfo(pic_path);
                file.CopyTo(pic_dir + lbl_id.Text + ".png", true);
            }

            //load pic to the main form (if this is the current display user)
            if (parent.emp_id == this.id)
                parent.emp_img = System.Drawing.Image.FromFile(pic_dir + lbl_id.Text + ".png");

            //update book info in table TBL_BOOK
            cmd.CommandText = "UPDATE TBL_EMP SET E_NAME = @name, PHONE = @phone, BDAY = @bday, E_ROLE = @role, PWORD = @pass WHERE ID = " + lbl_id.Text;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", txt_name.Texts);
            cmd.Parameters.AddWithValue("@phone", txt_phone.Texts);
            cmd.Parameters.AddWithValue("@bday", txt_bday.Texts);
            cmd.Parameters.AddWithValue("@role", is_manager);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.ExecuteNonQuery();

            //Update book info in table TBL_EMP_IMPORT
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE TBL_EMP_IMPORT SET EMP_NAME = @name WHERE EMP_ID = " + lbl_id.Text;
            cmd.Parameters.AddWithValue("@name", txt_name.Texts);
            cmd.ExecuteNonQuery();

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
                string[] split_line = pic_dir.Split('/');
                if (dlg.FileName.Contains(lbl_id.Text + ".png") && dlg.FileName.Contains(pic_dir))
                {
                    MessageBox.Show("The picture you choosen was the same one with the previous", "Opps");
                    return;
                }

                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(dlg.FileName);

                FileInfo file = new FileInfo(dlg.FileName);
                file.CopyTo("new_pic.png", true);
                pic_path = "new_pic.png";
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
    }
}

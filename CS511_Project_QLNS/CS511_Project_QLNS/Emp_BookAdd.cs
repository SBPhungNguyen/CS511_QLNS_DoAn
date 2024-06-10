using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
        FileInfo file;

        public Emp_BookAdd(Form2 parent)
        {
            InitializeComponent();
            parent_form = parent;

            cbb_type.SelectedIndex = 0;

            file = new FileInfo("icon_picture.png");


            connect = co.connect;
            sqlCon = new SqlConnection(connect);
            //if (sqlCon.State == ConnectionState.Closed )
            //{
            //    sqlCon.Open();
            //}
            //cmd = new SqlCommand();
            //cmd.Connection = sqlCon;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT MAX(ID) FROM TBL_BOOK";
            //int max = (int)cmd.ExecuteScalar();
            //id = max + 1;
            //lbl_id.Text = id.ToString();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_exit_Click(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_author.Texts!="" && txt_title.Texts!="" && txt_im_price.Texts!=""&&txt_sell_price.Texts!=""&&txt_des.Texts!="")
            {
                //add new data to sql;
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();

                cmd.CommandText = "INSERT INTO TBL_BOOK (TITLE, AUTHOR, GENRE, IM_PRICE, EX_PRICE, TXT, QUANTITY) VALUES (@title, @author, @genre, @im, @ex, @txt, 0)";

                cmd.Parameters.AddWithValue("@title", txt_title.Texts);
                cmd.Parameters.AddWithValue("@author", txt_author.Texts);
                cmd.Parameters.AddWithValue("@genre", cbb_type.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@im", int.Parse(txt_im_price.Texts));
                cmd.Parameters.AddWithValue("@ex", int.Parse(txt_sell_price.Texts));
                cmd.Parameters.AddWithValue("@txt", txt_des.Texts);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT MAX(ID) FROM TBL_BOOK";
                id = (int)cmd.ExecuteScalar();

                //copy pic to desired dir
                file.CopyTo(co.local_dir + id + ".png", true);

                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE TBL_BOOK SET PIC = @pic WHERE ID = @id";
                cmd.Parameters.AddWithValue("@pic", id);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added successfully","Notification");

                btn_exit_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Please fill in all the blanks", "Opps");
            }
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
    }
}

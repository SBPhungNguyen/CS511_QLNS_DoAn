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
    public partial class Emp_BookEdit : Form
    {
        connection co = new connection();
        string connect;
        string local_dir;
        SqlConnection sqlCon;
        SqlCommand cmd;

        string pic_path;
        public Emp_BookEdit()
        {
            InitializeComponent();

            connect = co.connect; 
            local_dir = co.local_dir;
            sqlCon = new SqlConnection(connect);
            
        }

        public void LoadData(int id, Image img, string title, string author, string genre, string im_price, string ex_price, string des, string quantity)
        {
            lbl_id.Text = id.ToString();
            ptb_img.BackgroundImage = img;
            txt_title.Texts = title;
            txt_author.Texts = author;
            txt_des.Texts = des.ToString();
            txt_quantity.Text = quantity.ToString();
            //adjust to have the correct format of money 
            cbb_type.SelectedIndex = int.Parse(genre) - 1;
            txt_im_price.Texts = im_price;
            txt_sell_price.Texts = ex_price;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ptb_img.BackgroundImage.Dispose();
            ptb_img.BackgroundImage = null;
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
            ptb_img.BackgroundImage.Dispose();
            ptb_img.BackgroundImage = null;
            this.Dispose();
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //edit the book detail in TBL_BOOK
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
                file.CopyTo(local_dir + lbl_id.Text + ".png", true);
            }

            //update book info in table TBL_BOOK
            cmd.CommandText = "UPDATE TBL_BOOK SET TITLE = @title, AUTHOR = @author, GENRE = @genre, IM_PRICE = @im, EX_PRICE = @ex, TXT = @txt WHERE ID = " + lbl_id.Text;
            cmd.Parameters.AddWithValue("@title", txt_title.Texts);
            cmd.Parameters.AddWithValue("@author", txt_author.Texts);
            cmd.Parameters.AddWithValue("@genre", (cbb_type.SelectedIndex + 1).ToString());
            cmd.Parameters.AddWithValue("@im", int.Parse(txt_im_price.Texts));
            cmd.Parameters.AddWithValue("@ex", int.Parse(txt_sell_price.Texts));
            cmd.Parameters.AddWithValue("@txt", txt_des.Texts);
            cmd.ExecuteNonQuery();

            //Update book info in table TBL_REC_DETAIL
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = sqlCon;
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Clear();
            cmd2.CommandText = "UPDATE TBL_REC_DETAIL SET BOOK_NAME = @book_name WHERE ID_BOOK = @id";
            //string book_name = txt_title.Texts;
            //MessageBox.Show(book_name);
            cmd2.Parameters.AddWithValue("@book_name", txt_title.Texts);
            cmd2.Parameters.AddWithValue("@id", lbl_id.Text);
            cmd2.ExecuteNonQuery();

            //Update book info in table TBL_IMP_DETAIL
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = sqlCon;
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Clear();
            cmd3.CommandText = "UPDATE TBL_IMP_DETAIL SET BOOK_NAME = @book_name WHERE ID_BOOK = @id";
            cmd3.Parameters.AddWithValue("@book_name", txt_title.Texts);
            cmd3.Parameters.AddWithValue("@id", lbl_id.Text);
            cmd3.ExecuteNonQuery();

            sqlCon.Close();
            MessageBox.Show("This has been updated","Notification");
        }

        private void ptb_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Picture (.png) | *.png";
            dlg.Multiselect = false;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] split_line = local_dir.Split('/');
                if (dlg.FileName.Contains(lbl_id.Text + ".png") && dlg.FileName.Contains(local_dir))
                {
                    MessageBox.Show("The picture you chose was the same one with the previous", "Opps");
                    return;
                }

                if (dlg.FileName.Contains("new_pic.png"))
                {
                    MessageBox.Show("This picture cannot be chosen, please choose another one", "Opps");
                    return;
                }
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(dlg.FileName);

                FileInfo file = new FileInfo(dlg.FileName);
                file.CopyTo("new_pic.png", true);
                pic_path = "new_pic.png";

            }
        }
    }
}

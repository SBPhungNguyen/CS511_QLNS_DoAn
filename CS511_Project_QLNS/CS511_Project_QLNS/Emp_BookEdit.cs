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
            sqlCon.Close();

            if (pic_path != null)
            {
                FileInfo file = new FileInfo(pic_path);
                file.CopyTo(local_dir + lbl_id.Text + ".png", true);
            }

            //add code here to save the pic to the desired dir

            //cmd.CommandText = "UPDATE TBL_BOOK SET TITLE = @title, AUTHOR = @author,  WHERE ID = " + lbl_id;
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
                if (dlg.FileName.Contains(lbl_id.Text + ".png") && dlg.FileName.Contains(split_line[0]))
                {
                    MessageBox.Show("The picture you choosen was the same one with the previous","Opps");
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

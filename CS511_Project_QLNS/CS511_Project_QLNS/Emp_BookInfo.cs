using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Emp_BookInfo : Form
    {
        public Emp_BookInfo()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image pic, string title, string author, string genre, string im_price, string ex_price, string txt, string quantity)
        {
            lbl_id.Text = id.ToString();
            ptb_img.BackgroundImage = pic;
            lbl_name.Text = title;
            lbl_author.Text = author;
            switch(genre)
            {
                case "1": lbl_genre.Text = "Classics"; break;
                case "2": lbl_genre.Text = "Fantasy"; break;
                case "3": lbl_genre.Text = "Self Help"; break;
                case "4": lbl_genre.Text = "Non-Fiction"; break;
                case "5": lbl_genre.Text = "Mystery"; break;
                case "6": lbl_genre.Text = "History"; break;
            }

            lbl_im_price.Text = string.Format("{0:#,###}", int.Parse(im_price));
            lbl_sell_price.Text = string.Format("{0:#,###}", int.Parse(ex_price));
            lbl_description.Text = txt;
            lbl_quantity.Text = quantity;
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
            ptb_img.BackgroundImage.Dispose();
        }
    }
}

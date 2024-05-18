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
    public partial class Emp_BookEdit : Form
    {
        public Emp_BookEdit()
        {
            InitializeComponent();
            
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

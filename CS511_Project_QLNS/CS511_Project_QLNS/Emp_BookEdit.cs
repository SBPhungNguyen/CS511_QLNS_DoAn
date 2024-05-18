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

        public void LoadData(int id, string title, string author, string genre, string im_price, string ex_price, string quantity, string des)
        {
            lbl_id.Text = id.ToString();
            txt_title.Text = title.ToString();
            txt_author.Text = author.ToString();
            txt_des.Text = des.ToString();
            txt_quantity.Text = quantity.ToString();
            //adjust to have the correct format of money 
            txt_im_price.Text = im_price.ToString();
            txt_sell_price.Text = ex_price.ToString();
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

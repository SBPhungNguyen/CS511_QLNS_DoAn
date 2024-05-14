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
    public partial class MakePurchase : Form
    {
        Form1 parent_form;
        Uct_Customer_Cart parent_uct;
        public MakePurchase(Form1 form1, Uct_Customer_Cart uct_Customer_Cart)
        {
            InitializeComponent();

            parent_form = form1;
            parent_uct = uct_Customer_Cart;

            lbl_total.Text = parent_uct.sumprice;
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
            btn_exit.BackgroundImage= Properties.Resources.Cross2_image;

        }
    }
}

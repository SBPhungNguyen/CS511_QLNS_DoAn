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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Uct_Customer_Home uct = new Uct_Customer_Home();
            uct.Location = new System.Drawing.Point(235, 105);
            this.Controls.Add(uct);

            //Uct_Customer_Cart uct = new Uct_Customer_Cart(); 
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //Uct_Customer_ReceiptSearch uct = new Uct_Customer_ReceiptSearch();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //Uct_Customer_Chat uct = new Uct_Customer_Chat();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

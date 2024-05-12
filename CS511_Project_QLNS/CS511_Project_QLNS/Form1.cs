using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{

    public partial class Form1 : Form
    {
        connection co = new connection();
        string constr;

        string dir = @"D:\\CS511_PIC";
        public static string local_dir = "Pic";

        public Color btn_normal = Color.FromArgb(24, 138, 93);
        public Color btn_chosen = Color.FromArgb(31, 181, 122);

        public Form1()
        {
            InitializeComponent();

            //this is to set the connect string
            constr = co.connect;

            //this is to create an transfer the info from the dir to the D: absolute link
            if (!Directory.Exists(local_dir))
            {
                MessageBox.Show("Yeah");
            }

            //this is to get the uct_home show up
            Uct_Customer_Home uct_Customer_Home = new Uct_Customer_Home();
            uct_Customer_Home.Location = new System.Drawing.Point(235, 105);
            uct_Customer_Home.Name = "uct_Customer_Home";
            this.Controls.Add(uct_Customer_Home);



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

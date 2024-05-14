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
        public static string local_dir;

        //this is to get the info of the cart
        public string[] cart_info = new string[200];
        public int[] cart_price = new int[200];
        public int cart_count;

        public Color color_btn_normal = Color.FromArgb(24, 138, 93);
        public Color color_btn_chosen = Color.FromArgb(31, 181, 122);

        Uct_Customer_Home uct_Customer_Home;
        Uct_Customer_Cart uct_Customer_Cart;
        Uct_Customer_ReceiptSearch uct_Customer_ReceiptSearch = new Uct_Customer_ReceiptSearch();
        Uct_Customer_Chat uct_Customer_Chat = new Uct_Customer_Chat();

        public Form1()
        {
            InitializeComponent();

            //this is to set the connect string and get the local directory
            constr = co.connect;
            local_dir = co.local_dir;

            //this is to create an transfer the info from the dir to the D: absolute link
            if (!Directory.Exists(local_dir))
            {
                MessageBox.Show("Yeah");
            }

            //this is to get the uct_home show up
            btn_home.BackColor = color_btn_chosen;
            Uct_Customer_Home uct_Customer_Home = new Uct_Customer_Home();
            uct_Customer_Home.Location = new System.Drawing.Point(235, 105);
            uct_Customer_Home.Name = "uct_Customer_Home";
            this.Controls.Add(uct_Customer_Home);

            cart_count = 0;

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

        private void btn_home_Click(object sender, EventArgs e)
        {
            btn_home.BackColor = color_btn_chosen;
            btn_receipt.BackColor = color_btn_normal;
            btn_cart.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;

            uct_Customer_Home = new Uct_Customer_Home();
            uct_Customer_Home.Location = new System.Drawing.Point(235, 105);
            uct_Customer_Home.Name = "uct_Customer_Home";
            this.Controls.Add(uct_Customer_Home);
            uct_Customer_Home.BringToFront();

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            btn_home.BackColor = color_btn_normal;
            btn_cart.BackColor = color_btn_chosen;
            btn_receipt.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;

            uct_Customer_Cart = new Uct_Customer_Cart(this);

            uct_Customer_Cart.Location = new System.Drawing.Point(235, 105);
            uct_Customer_Cart.Name = "uct_Customer_Cart";
            this.Controls.Add(uct_Customer_Cart);
            uct_Customer_Cart.BringToFront();
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            btn_home.BackColor = color_btn_normal;
            btn_cart.BackColor = color_btn_normal;
            btn_receipt.BackColor = color_btn_chosen;
            btn_chat.BackColor = color_btn_normal;

            uct_Customer_ReceiptSearch = new Uct_Customer_ReceiptSearch();
            uct_Customer_ReceiptSearch.Location = new System.Drawing.Point(235, 105);
            uct_Customer_ReceiptSearch.Name = "uct_Customer_ReceiptSearch";
            this.Controls.Add(uct_Customer_ReceiptSearch);
            uct_Customer_ReceiptSearch.BringToFront();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            btn_home.BackColor = color_btn_normal;
            btn_cart.BackColor = color_btn_normal;
            btn_receipt.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_chosen;

            uct_Customer_Chat = new Uct_Customer_Chat();
            uct_Customer_Chat.Location = new System.Drawing.Point(235, 105);
            uct_Customer_Chat.Name = "uct_Customer_Chat";
            this.Controls.Add(uct_Customer_Chat);
            uct_Customer_Chat.BringToFront();
        }
    }
}

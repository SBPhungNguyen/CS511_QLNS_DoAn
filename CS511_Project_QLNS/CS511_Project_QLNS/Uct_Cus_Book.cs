﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CS511_Project_QLNS
{
    public partial class Uct_Cus_Book : UserControl
    {
        public int id;
        public Form1 parent_form;
        public Image img
        {
            get {  return ptb_img.BackgroundImage; }
            set { ptb_img.BackgroundImage = value; }
        }
        public string title
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }
        public string price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }
        }
        public int quantity;


        public Uct_Cus_Book()
        {
            InitializeComponent();

        }
        public void LoadData(int id, Image pic, string title, string price, int quantity)
        {
            this.id = id;
            ptb_img.BackgroundImage = pic;
            this.title = title;
            this.quantity = quantity;

            string formattedNumber = string.Format("{0:#,###}", int.Parse(price));
            this.price = formattedNumber;
        }

        private void Uct_Cus_Book_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo(this);

            Form form = GetParentForm();       
            form.Hide();
            bi.ShowDialog();

            form.Show();
        }

        //this is to find the parent form of this 
        public Form GetParentForm()
        {
            Control control = this;
            while (control != null && !(control is Form))
            {
                control = control.Parent;
            }
            return control as Form;
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void ptb_img_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void ptb_cart_Click(object sender, EventArgs e)
        {
            if (quantity==0)
            {
                MessageBox.Show("Sorry, this product has been run out");
                return;
            }
            else
            {
                parent_form = (Form1) GetParentForm();

                int flag_found = 0;

                for (int i=0;i<parent_form.cart_count;i++)
                {
                    string[] split_line = parent_form.cart_info[i].Split('*');
                    if (split_line[0] ==id.ToString())
                    {
                        flag_found = 1;
                        break;
                    }
                }
                if (flag_found == 0)
                {
                    parent_form.cart_info[parent_form.cart_count]=id.ToString() + "*1";
                    parent_form.cart_count++;
                    MessageBox.Show("Added to cart successfully", "Notification");
                    return;
                }
                MessageBox.Show("This has been in your cart already", "Notification");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Emp_ImportAdd : UserControl
    {
        Emp_ImportAdd parent;
        public string ID
        {
            get { return lbl_id.Text; }
            set { lbl_id.Text = value; }
        }
        public string title
        {
            get { return lbl_title.Text; }
            set { lbl_title.Text = value;}
        }
        public string price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }
        }
        public string quantity
        {
            get { return lbl_quantity.Text; }
            set { lbl_quantity.Text = value;}
        }
        public string sum
        {
            get { return lbl_sum.Text; }
            set { lbl_sum.Text = value;}    
        }
        public Uct_Emp_ImportAdd(Emp_ImportAdd form)
        {
            InitializeComponent();
            this.parent = form;

        }
        public void LoadData(string id, string title, string price, string quantity)
        {
            this.ID = id;
            this.title = title;
            this.price = string.Format("{0:#,###}", int.Parse(price));
            this.quantity = quantity;
            int s = int.Parse(quantity) * int.Parse(price);
            this.sum = string.Format("{0:#,###}", s);
        }
    }
}

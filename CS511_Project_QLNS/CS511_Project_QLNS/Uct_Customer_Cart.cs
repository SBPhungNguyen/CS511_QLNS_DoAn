﻿using System;
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
    public partial class Uct_Customer_Cart : UserControl
    {
        public Uct_Customer_Cart()
        {
            InitializeComponent();
            fpnl_cart.AutoScroll = true;
            fpnl_cart.WrapContents = true;
        }
    }
}
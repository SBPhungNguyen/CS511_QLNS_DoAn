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
    public partial class Uct_Cus_Receipt : UserControl
    {
        public Uct_Cus_Receipt()
        {
            InitializeComponent();
        }
        public void LoadData(string name, string price, string quantity, string sum)
        {
            lbl_name.Text = name;
            lbl_price.Text = price;
            lbl_quantity.Text = quantity;
            lbl_sum.Text = sum;
        }
    }
}

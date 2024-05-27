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
    public partial class Uct_Emp_Detail : UserControl
    {
        public Uct_Emp_Detail()
        {
            InitializeComponent();
        }
        public void LoadData(int id, string title, string price, string quantity, string sum)
        {
            lbl_id.Text = id.ToString();
            lbl_title.Text = title;
            lbl_price.Text = price;
            lbl_quantity.Text = quantity;
            lbl_sum.Text = sum;
        }
    }
}

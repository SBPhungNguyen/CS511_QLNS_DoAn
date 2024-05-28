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
    public partial class Uct_Emp_Cashier : UserControl
    {
        public int id;
        public Uct_Emp_Cashier()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image pic, string name, string role)
        {
            this.id = id;
            ptb_img.BackgroundImage = pic;
            lbl_name.Text = name;
            lbl_role.Text = role;
        }
    }
}

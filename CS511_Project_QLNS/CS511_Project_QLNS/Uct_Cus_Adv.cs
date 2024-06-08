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
    public partial class Uct_Cus_Adv : UserControl
    {
        connection co = new connection();
        public Uct_Cus_Adv()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            ptb_bigimg.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "c.png");
            ptb_smallimg1.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "b.png");
            ptb_smallimg2.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "a.png");
        }
    }
}

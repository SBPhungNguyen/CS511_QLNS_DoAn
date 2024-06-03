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
    public partial class Uct_Cus_Chat : UserControl
    {
        public Uct_Cus_Chat()
        {
            InitializeComponent();
        }
        public void LoadData(Image img, string name, string txt)
        {
            ptb_img.BackgroundImage = img;
            lbl_name.Text = name;
            rtb_text.Text = txt;
        }
    }
}

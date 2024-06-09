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
    public partial class Uct_Cus_BookInfo_General : UserControl
    {
        public Uct_Cus_BookInfo_General()
        {
            InitializeComponent();
        }
        public void LoadData(Image img, string title, string star, int count, decimal price)
        {
            ptb_img.BackgroundImage = img;
            lbl_name.Text = title;
            lbl_star.Text = star;
            if (count == 0)
            {
                lbl_cmt.Text = "There is no comment yet";
            }
            else
            {
                lbl_cmt.Text = "There is/are " + count + " comment(s)";
            }
            string str = price.ToString("0.##");
            string formattedNumber = string.Format("{0:#,###}", int.Parse(str));

            lbl_price.Text = formattedNumber;
        }
    }
}

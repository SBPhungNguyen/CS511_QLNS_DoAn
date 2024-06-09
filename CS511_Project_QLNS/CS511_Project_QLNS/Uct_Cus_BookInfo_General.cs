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
        public string star_point
        {
            get { return lbl_star.Text; } set { lbl_star.Text = value;}
        }
        public Uct_Cus_BookInfo_General()
        {
            InitializeComponent();
        }
        public void LoadData(Image img, string title, double star, int count, decimal price)
        {
            ptb_img.BackgroundImage = img;
            lbl_name.Text = title;
            if (star == 0 || star == 1 || star == 2 || star == 3 || star == 4 || star == 5)
                lbl_star.Text = star.ToString()+".0";
            else
                lbl_star.Text = star.ToString();
            CheckStar(star);
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
        public void DisposePic()
        {
            ptb_img.BackgroundImage.Dispose();
        }
        public void Set_lbl_cmt(int count)
        {
            if (count == 0)
            {
                lbl_cmt.Text = "There is no comment yet";
            }
            else
            {
                lbl_cmt.Text = "There is/are " + count + " comment(s)";
            }
        }
        public void CheckStar(double star)
        {
            switch (star)
            {
                case 0:
                    {
                        ptb_star1.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                        return;
                    }
                case 1:
                    {
                        ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                        return;
                    }
                case 2:
                    {
                        ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                        return;
                    }
                case 3:
                    {
                        ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                        return;
                    }
                case 4:
                    {
                        ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                        return;
                    }
                case 5:
                    {
                        ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_yellow;
                        return;
                    }
            }
            if (star>0&&star<1)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_half;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                return;
            }
            else if (star>1 && star<2)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_half;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                return;
            }
            else if (star > 2 && star < 3)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_half;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                return;
            }
            else if (star > 3 && star < 4)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_half;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
                return;
            }
            else if (star > 4 && star < 5)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_half;
                return;
            }
        }
    }
}

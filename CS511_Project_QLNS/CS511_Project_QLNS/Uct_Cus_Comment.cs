using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Cus_Comment : UserControl
    {
        public Image pic
        {
            get { return ptb_img.BackgroundImage; }
            set { ptb_img.BackgroundImage = value;}
        }
        public string name
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }
        public string description
        {
            get { return rtb_txt.Text; }
            set { rtb_txt.Text = value; }
        }
        public Uct_Cus_Comment()
        {
            InitializeComponent();
        }

        public void LoadData(string name, int gender, int star, string des)
        {
            lbl_name.Text = name;
            rtb_txt.Text = des;

            if (gender == 0)
                ptb_img.BackgroundImage = Properties.Resources.icon_male;
            else
                ptb_img.BackgroundImage= Properties.Resources.icon_female;

            int count_star = star;
            switch (count_star)
            {
                case 1: ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;  
                        break;
                case 2: ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        break;
                case 3: ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                        break;
                case 4: ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                        break;
                case 5: ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                        ptb_star5.BackgroundImage = Properties.Resources.icon_star_yellow;
                        break;

            }
        }
    }
}

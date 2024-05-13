using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class BookInfo : Form
    {
        public int id;
        public int star_chosen;
        public int is_female;
        public int star_count;

        connection con = new connection();
        string connect;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public BookInfo(Uct_Cus_Book uct)
        {
            InitializeComponent();

            fpnl_cmt.AutoScroll = true;
            fpnl_cmt.WrapContents = true;

            rad_male.Checked = true;
            is_female = 0;
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_male;

            this.id = uct.id;


            connect = con.connect;
            star_chosen = 0;


            LoadData();

            LoadComment();
        }
        public void LoadData()
        {
            sqlCon = new SqlConnection(connect);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = " + id;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(con.local_dir + rd.GetString(1) + ".png");
                lbl_name.Text = rd.GetString(2);
                lbl_author.Text = rd.GetString(3);
                string k = rd.GetString(4);
                switch(k)
                {
                    case "1": lbl_genre.Text = "Classics";  break;
                    case "2": lbl_genre.Text = "Fantasy"; break;
                    case "3": lbl_genre.Text = "Self Help"; break;
                    case "4": lbl_genre.Text = "Non-fiction"; break;
                    case "5": lbl_genre.Text = "Mystery"; break;
                    case "6": lbl_genre.Text = "History"; break;
                }

                string str = rd.GetDecimal(6).ToString("0.##");
                string formattedNumber = string.Format("{0:#,###}", int.Parse(str));

                lbl_price.Text = formattedNumber;
                lbl_description.Text = rd.GetString(7);
            }

            sqlCon.Close();
        }

        public void LoadComment()
        {
            sqlCon = new SqlConnection(connect);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK_COMMENT WHERE ID_BOOK = " + id;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Uct_Cus_Comment uct = new Uct_Cus_Comment();
                uct.LoadData(rd.GetString(3), rd.GetInt32(2), rd.GetInt32(1), rd.GetString(4));
                fpnl_cmt.Controls.Add(uct);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.BackgroundImage = Properties.Resources.Cross3_Img;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackgroundImage = Properties.Resources.Cross2_image;
        }

        //these codes is for changing pic in comment
        private void rad_male_CheckedChanged(object sender, EventArgs e)
        {
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_male;
            is_female = 0;
        }

        private void rad_female_CheckedChanged(object sender, EventArgs e)
        {
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_female;
            is_female = 1;

        }

        //these codes below is for the stars in the comments
        private void ptb_star1_MouseEnter(object sender, EventArgs e)
        {
            if (star_chosen==0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star1_MouseLeave(object sender, EventArgs e)
        {
            if (star_chosen==0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }
        private void ptb_star1_Click(object sender, EventArgs e)
        {
            ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
            ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
            ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
            ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            star_chosen = 1;
            star_count = 1;
        }
        private void ptb_star2_MouseEnter(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }
        private void ptb_star2_MouseLeave(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star2_Click(object sender, EventArgs e)
        {
            ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
            ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
            ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            star_chosen = 1;
            star_count = 2;
        }

        private void ptb_star3_MouseEnter(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star3_MouseLeave(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star3_Click(object sender, EventArgs e)
        {
            ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
            ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            star_chosen = 1;
            star_count = 3;
        }

        private void ptb_star4_MouseEnter(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star4_MouseLeave(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star4_Click(object sender, EventArgs e)
        {
            ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            star_chosen = 1;
            star_count = 4;
        }

        private void ptb_star5_MouseEnter(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_yellow;
            }
        }

        private void ptb_star5_MouseLeave(object sender, EventArgs e)
        {
            if (star_chosen == 0)
            {
                ptb_star1.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star2.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star3.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star4.BackgroundImage = Properties.Resources.icon_star_black;
                ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }

        private void ptb_star5_Click(object sender, EventArgs e)
        {
            ptb_star1.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star2.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star3.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star4.BackgroundImage = Properties.Resources.icon_star_yellow;
            ptb_star5.BackgroundImage = Properties.Resources.icon_star_yellow;
            star_chosen = 1;
            star_count = 5;
        }

        private void btn_postcomment_Click(object sender, EventArgs e)
        {
            if (txt_cmtname.Texts == "" || rtb_cmttext.Text == "" || star_chosen == 0)
            {
                MessageBox.Show("Please feel in all the blanks", "Opps");
                return;
            }
            else
            {
                //write the code to show on fpnl_comment and save to db
            }
        }
    }
}

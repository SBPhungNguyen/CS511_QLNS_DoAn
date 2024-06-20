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
    public partial class Uct_Cus_BookInfo_Comment : UserControl
    {
        public int id;
        public int star_chosen;
        public int is_female;
        public int star_count;

        connection con = new connection();
        string connect;
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Cus_BookInfo_Comment(int id)
        {
            InitializeComponent();
            fpnl_cmt.AutoScroll = true;
            fpnl_cmt.WrapContents = true;

            connect = con.connect;

            this.id = id;

            rad_male.Checked = true;
            is_female = 0;
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_male;

            star_chosen = 0;


            LoadData();
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
            cmd.CommandText = "SELECT * FROM TBL_BOOK_COMMENT WHERE ID_BOOK = " + id;

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Uct_Cus_Comment uct = new Uct_Cus_Comment();
                uct.LoadData(rd.GetString(3), rd.GetInt32(2), rd.GetInt32(1), rd.GetString(4));
                fpnl_cmt.Controls.Add(uct);
            }
            rd.Close();
            sqlCon.Close();
        }

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
            if (star_chosen == 0)
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
            if (star_chosen == 0)
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
                Uct_Cus_Comment uct = new Uct_Cus_Comment();
                uct.LoadData(txt_cmtname.Texts, is_female, star_count, rtb_cmttext.Text);
                fpnl_cmt.Controls.Add(uct);

                sqlCon = new SqlConnection(con.connect);
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO TBL_BOOK_COMMENT VALUES (@ID, @STAR, @GENDER, @cmt , @TXT)";
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@STAR", star_count);
                cmd.Parameters.AddWithValue("@GENDER", is_female);
                cmd.Parameters.AddWithValue("@cmt", txt_cmtname.Texts);
                cmd.Parameters.AddWithValue("@TXT", rtb_cmttext.Text);

                cmd.ExecuteNonQuery();
                sqlCon.Close();


                BookInfo bookInfo = this.Parent.Parent as BookInfo;
                //if (bookInfo != null)
                {

                    if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
                    cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM TBL_BOOK_COMMENT WHERE ID_BOOK = " + id;
                    SqlDataReader dr = cmd.ExecuteReader();
                    double sum = 0;
                    int count = 0;
                    while (dr.Read())
                    {
                        sum = sum + dr.GetInt32(1);
                        count++;
                    }
                    dr.Close();
                    sqlCon.Close();
                    double new_star;
                    if (sum == 0)
                    {
                        new_star = 0;
                    }
                    else
                    {
                        if (Math.Floor((double)sum / count) == (double)sum / count)
                        {
                            new_star = (double)sum / count;
                        }
                        else
                            // Round to one decimal place using MidpointRounding.ToEven
                            new_star = Math.Round((double)sum / count, 1, MidpointRounding.ToEven);
                    }

                    Uct_Cus_BookInfo_General uct1 = bookInfo.FindControlByName(bookInfo, "uct_Cus_BookInfo_General") as Uct_Cus_BookInfo_General;
                    //if (uct != null)
                    {
                        string formatted;
                        uct1.Set_lbl_cmt(count);
                        uct1.CheckStar(new_star);
                        if (new_star == 0 || new_star == 1 || new_star == 2 || new_star == 3 || new_star == 4 || new_star == 5)
                            formatted = new_star + ".0";
                        else
                        {
                            formatted = new_star.ToString();
                        }
                        uct1.star_point = formatted;
                    }
                }

                //reset all values

                txt_cmtname.Texts = "";
                rad_male.Checked = true;
                is_female = 0;
                star_chosen = 0;
                star_count = 0;
                rtb_cmttext.Text = "";
                ptb_star1.BackgroundImage = ptb_star2.BackgroundImage = ptb_star3.BackgroundImage = ptb_star4.BackgroundImage = ptb_star5.BackgroundImage = Properties.Resources.icon_star_black;
            }
        }
    }
}

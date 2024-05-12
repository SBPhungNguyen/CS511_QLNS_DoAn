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

        connection con = new connection();
        string connect;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public BookInfo(Uct_Cus_Book uct)
        {
            InitializeComponent();

            rad_male.Checked = true;
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_male;

            this.id = uct.id;


            connect = con.connect;


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

        private void rad_male_CheckedChanged(object sender, EventArgs e)
        {
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_male;
        }

        private void rad_female_CheckedChanged(object sender, EventArgs e)
        {
            ptb_cmtpic.BackgroundImage = Properties.Resources.icon_female;

        }
    }
}

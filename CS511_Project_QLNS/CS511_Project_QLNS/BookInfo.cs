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

        public Uct_Cus_BookInfo_General uct_Cus_BookInfo_General;
        public Uct_Cus_BookInfo_Detail uct_Cus_BookInfo_Detail;
        public Uct_Cus_BookInfo_Comment uct_Cus_BookInfo_Comment;
        public BookInfo(Uct_Cus_Book uct)
        {
            InitializeComponent();

            this.id = uct.id;

            fpnl_item.AutoScroll = true;
            fpnl_item.WrapContents = true;


            uct_Cus_BookInfo_General = new Uct_Cus_BookInfo_General();
            uct_Cus_BookInfo_General.Name = "uct_Cus_BookInfo_General";
            uct_Cus_BookInfo_General.Location = new Point(0, 40);

            uct_Cus_BookInfo_Detail = new Uct_Cus_BookInfo_Detail();
            uct_Cus_BookInfo_Detail.Name = "uct_Cus_BookInfo_Detail";

            connect = con.connect;
            sqlCon = new SqlConnection(connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }

            double sum = 0;
            int count = 0;
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK_COMMENT WHERE ID_BOOK = " + id;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sum = sum + reader.GetInt32(1);
                count++;
            }
            reader.Close();

            double star;
            if (sum == 0)
            {
                star = 0;
            }
            else
            {
                if (Math.Floor((double)sum / count) == (double)sum / count)
                {
                    star = (double)sum / count;
                }

                // Round to one decimal place using MidpointRounding.ToEven
                star =  Math.Round((double)sum / count, 1, MidpointRounding.ToEven);
            }
                //star = Math.Round((double)sum / count,1);

            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = "+id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Image img = System.Drawing.Image.FromFile(con.local_dir + dr.GetString(1) + ".png");

                uct_Cus_BookInfo_General.LoadData(img, dr.GetString(2),star,count,dr.GetDecimal(6));
                uct_Cus_BookInfo_Detail.LoadData(dr.GetInt32(0), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDecimal(6), dr.GetInt32(8).ToString(), dr.GetString(7));
            }
            dr.Close();
            sqlCon.Close();

            fpnl_item.Controls.Add(uct_Cus_BookInfo_General);


            fpnl_item.Controls.Add(uct_Cus_BookInfo_Detail);

            uct_Cus_BookInfo_Comment = new Uct_Cus_BookInfo_Comment(id);
            uct_Cus_BookInfo_Comment.Name = "uct_Cus_BookInfo_Comment";
            fpnl_item.Controls.Add(uct_Cus_BookInfo_Comment);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            uct_Cus_BookInfo_General.DisposePic();
            this.Dispose();
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

        public Control FindControlByName(Control control, string controlName)
        {
            if (control.Name == controlName)
            {
                return control;
            }

            foreach (Control childControl in control.Controls)
            {
                Control foundControl = FindControlByName(childControl, controlName);
                if (foundControl != null)
                {
                    return foundControl;
                }
            }
            return null;
        }
    }
}

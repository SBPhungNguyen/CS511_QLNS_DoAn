using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    }
}

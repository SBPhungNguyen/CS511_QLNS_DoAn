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
    public partial class Uct_Customer_Home : UserControl
    {
        connection con = new connection();
        string connect;

        SqlConnection sqlCon;

        string local_dir = "Pic/";
        
        public Uct_Customer_Home()
        {
            InitializeComponent();
            fpnl_books.WrapContents = true; 
            fpnl_books.AutoScroll = true;

            connect = con.connect;

            sqlCon = new SqlConnection(connect);

            LoadData();

        }

        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from TBL_BOOK";

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

                uct_Cus_Book.LoadData(rd.GetInt32(0),img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"));
                fpnl_books.Controls.Add(uct_Cus_Book);
            }

        }
    }
}

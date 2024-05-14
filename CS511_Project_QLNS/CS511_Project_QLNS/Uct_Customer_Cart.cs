using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Customer_Cart : UserControl
    {
        public string connect;
        public string dir;
        connection con = new connection();

        public Form1 parent_form;

        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Customer_Cart(Form1 parent)
        {
            InitializeComponent();
            fpnl_cart.AutoScroll = true;
            fpnl_cart.WrapContents = true;

            connect = con.connect;
            dir =con.local_dir;
            sqlCon = new SqlConnection(connect);

            parent_form = parent;

            LoadData(); 
        }
        
        public void LoadData()
        {
            for (int i=0;i<parent_form.cart_count;i++)
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }

                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;

                string[] split_line = parent_form.cart_info[i].Split('*');
                cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = "+split_line[0];
                SqlDataReader reader = cmd.ExecuteReader ();
                if (reader.Read())
                {
                    Uct_Cus_Product uct = new Uct_Cus_Product();

                    Image img = System.Drawing.Image.FromFile(dir + reader.GetString(1) + ".png");

                    uct.LoadData(img,reader.GetString(2), reader.GetDecimal(6).ToString("0.##"), split_line[1], reader.GetInt32(8));
                    fpnl_cart.Controls.Add(uct);
                }
                sqlCon.Close();

            }
        }
    }
}

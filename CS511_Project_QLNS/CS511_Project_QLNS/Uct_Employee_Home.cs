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
using ZXing.OneD;

namespace CS511_Project_QLNS
{
    public partial class Uct_Employee_Home : UserControl
    {
        connection co = new connection();
        string connect;
        string local_dir;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        public int is_displayed_button;
        public Uct_Employee_Home()
        {
            InitializeComponent();
            fpnl_books.WrapContents = true;
            fpnl_books.AutoScroll = true;

            connect = co.connect;
            local_dir = co.local_dir;

            sqlCon = new SqlConnection(connect);

            is_displayed_button = 0;
            btn_all.BackColor = color_btn_cate_chosen;

            
        }

        public void LoadData()
        {

        }
    }
}

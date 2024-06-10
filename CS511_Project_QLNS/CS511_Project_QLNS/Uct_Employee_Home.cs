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
        public string connect;
        public string local_dir;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        Uct_Emp_Adv uct_Emp_Adv;
        Uct_Emp_BookSearch uct_Emp_BookSearch;
        Uct_Emp_HomeInfo uct_Emp_HomeInfo;

        public Uct_Employee_Home()
        {
            InitializeComponent();
            fpnl_item.WrapContents = true;
            fpnl_item.AutoScroll = true;

            LoadUct();
        }
        public void LoadUct()
        {
            uct_Emp_Adv = new Uct_Emp_Adv();
            uct_Emp_Adv.Name = "uct_Emp_Adv";
            fpnl_item.Controls.Add(uct_Emp_Adv);

            uct_Emp_BookSearch = new Uct_Emp_BookSearch();
            uct_Emp_BookSearch.Name = "uct_Emp_BookSearch";
            fpnl_item.Controls.Add(uct_Emp_BookSearch);

            uct_Emp_HomeInfo = new Uct_Emp_HomeInfo();
            uct_Emp_HomeInfo.Name = "uct_Emp_HomeInfo";
            fpnl_item.Controls.Add(uct_Emp_HomeInfo);
        }
    }
}

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
    public partial class Uct_Employee_Chat : UserControl
    {
        public Timer timer = new Timer();
        int count_msg;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Employee_Chat()
        {
            InitializeComponent();

            fpnl_chat.AutoScroll = true;
            fpnl_chat.WrapContents = true;

            sqlCon = new SqlConnection(co.connect);
            LoadCount();
            LoadData();

            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        public void LoadCount()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM TBL_CHAT";
            count_msg = (int)(cmd.ExecuteScalar());
            sqlCon.Close();
        }

        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_CHAT";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name;
                Image img;
                if (dr.GetString(1) == "0")
                {
                    name = "Guest";
                    img = Properties.Resources.icon_user2;
                }
                else
                {
                    name = "Book Store";
                    img = Properties.Resources.bookstore;
                }
                Uct_Cus_Chat uct = new Uct_Cus_Chat();
                uct.LoadData(img, name, dr.GetString(2));
                fpnl_chat.Controls.Add(uct);
            }
            dr.Close();
            sqlCon.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM TBL_CHAT";
            int count = (int)(cmd.ExecuteScalar());
            if (count == count_msg)
            {
                return;
            }
            count_msg = count;
            ClearFlowPanel();
            LoadData();
            sqlCon.Close();
        }

        private void ClearFlowPanel()
        {
            fpnl_chat.SuspendLayout();

            if (fpnl_chat.Controls.Count > 0)
            {
                for (int i = (fpnl_chat.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = fpnl_chat.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            fpnl_chat.ResumeLayout();
        }

        private void ptb_send_Click(object sender, EventArgs e)
        {
            count_msg++;
            string name = "Book Store";
            Image img = Properties.Resources.bookstore;
            Uct_Cus_Chat uct = new Uct_Cus_Chat();
            uct.LoadData(img, name, txt_text.Texts);
            fpnl_chat.Controls.Add(uct);

            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TBL_CHAT VALUES ('1','1',@txt)";
            cmd.Parameters.AddWithValue("@txt", txt_text.Texts);
            cmd.ExecuteNonQuery();
        }
    }
}

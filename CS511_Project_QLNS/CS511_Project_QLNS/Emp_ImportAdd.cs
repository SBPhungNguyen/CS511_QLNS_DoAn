using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Emp_ImportAdd : Form
    {
        Form2 parent_form;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;

        public string[] book_info = new string[400];                 //id*title*price*quantity
        public int book_count;
        public long sum_total = 0;

        
        public Emp_ImportAdd(Form2 form)
        {
            InitializeComponent();
            fpnl_detail.AutoScroll = true;
            fpnl_detail.WrapContents = true;

            parent_form = form;
            book_count = 0;

            sum_total = 0;

            lbl_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            
            //get emp info
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed ) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP WHERE ID = "+parent_form.emp_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_em_name.Text = dr.GetString(2);
                lbl_code.Text = dr.GetInt32(0).ToString();
            }
            sqlCon.Close();

            LoadBookIdCBB();
            LoadBookNameCBB();
        }
        public void LoadBookIdCBB()
        {
            cbb_bookid.Items.Clear();
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ID FROM TBL_BOOK";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbb_bookid.Items.Add(dr.GetInt32(0));
            }
            sqlCon.Close();
        }
        public void LoadBookNameCBB()
        {
            cbb_bookname.Items.Clear();
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TITLE FROM TBL_BOOK";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbb_bookname.Items.Add(dr.GetString(0));
            }
            sqlCon.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
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

        private void cbb_bookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_bookname.SelectedIndex = cbb_bookid.SelectedIndex;
        }

        private void cbb_bookname_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_bookid.SelectedIndex = cbb_bookname.SelectedIndex;
        }

        private void btn_guest_Click(object sender, EventArgs e)
        {
            txt_quantity.Texts = "";
            cbb_bookid.SelectedIndex = -1;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (cbb_bookid.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the desiring books","Opps");
                return;
            }
            if (txt_quantity.Texts == "")
            {
                MessageBox.Show("Please enter the amount of books", "Opps");
                return;
            }
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id",cbb_bookid.SelectedItem);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string price = dr.GetDecimal(5).ToString("0.##");

                book_info[book_count] = dr.GetInt32(0)+"*"+dr.GetString(2)+"*"+dr.GetDecimal(5).ToString("0.##")+"*"+txt_quantity.Texts;
                book_count++;
                Uct_Emp_ImportAdd uct = new Uct_Emp_ImportAdd(this);
                uct.LoadData(dr.GetInt32(0).ToString(),dr.GetString(2),dr.GetDecimal(5).ToString("0.##"),txt_quantity.Texts);
                fpnl_detail.Controls.Add(uct);

                cbb_bookid.Items.RemoveAt(cbb_bookid.SelectedIndex);
                cbb_bookname.Items.RemoveAt(cbb_bookname.SelectedIndex);
                txt_quantity.Texts = "";
            }
            sqlCon.Close();
            CalcualteTotal();
            Format_Sum();
        }

        public void CalcualteTotal()
        {
            long sum = 0;
            for (int i = 0; i < book_count;i++)
            {
                string[] splt_line = book_info[i].Split('*');
                long price = long.Parse(splt_line[2]);
                long quan = long.Parse(splt_line[3]);
                sum = sum + price*quan;
            }
            sum_total = sum;
            lbl_sumprice.Text = sum.ToString();
        }

        public void Format_Sum()
        {
            lbl_sumprice.Text = string.Format("{0:#,###}", long.Parse(lbl_sumprice.Text));
        }
    }
}

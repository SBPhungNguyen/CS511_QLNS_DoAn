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
using System.Net.Http.Headers;

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
            dr.Close();
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
            dr.Close();
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
            dr.Close();
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
            dr.Close();
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
            if (lbl_sumprice.Text == "0")
                return;
            lbl_sumprice.Text = string.Format("{0:#,###}", long.Parse(lbl_sumprice.Text));
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (lbl_sumprice.Text == "0")
            {
                MessageBox.Show("Please choose some products", "Opps");
                return;
            }

            if (sqlCon.State == ConnectionState.Closed) {  sqlCon.Open(); }

            // this is to save the receipt
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "INSERT INTO TBL_EMP_IMPORT (E_DATE, EMP_ID, EMP_NAME, TOTAL) VALUES (@date, @emp_id, @emp_name, @total)";
            cmd.Parameters.AddWithValue("@date",lbl_date.Text);
            cmd.Parameters.AddWithValue("@emp_id",parent_form.emp_id);
            cmd.Parameters.AddWithValue("@emp_name", lbl_em_name.Text);
            cmd.Parameters.AddWithValue("@total", int.Parse(sum_total.ToString()));
            cmd.ExecuteNonQuery();

            //this is to get the current import ID
            cmd = new SqlCommand();
            cmd.Connection= sqlCon;
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "SELECT MAX(ID) FROM TBL_EMP_IMPORT";
            int imp_id = (int)cmd.ExecuteScalar();

            // this is to save the receipt details
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO TBL_IMP_DETAIL (ID_IMP, ID_BOOK, BOOK_NAME, PRICE, QUANTITY, TOTAL) VALUES (@id, @id_book, @bookname, @price, @quan, @total)";
            for (int i=0;i<book_count;i++)
            {
                string[] split_line = book_info[i].Split('*');
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", imp_id);
                cmd.Parameters.AddWithValue("@id_book", int.Parse(split_line[0]));
                cmd.Parameters.AddWithValue("@bookname", split_line[1]);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(split_line[2]));
                cmd.Parameters.AddWithValue("@quan", int.Parse(split_line[3]));
                long total = long.Parse(split_line[2]) * long.Parse(split_line[3]);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.ExecuteNonQuery();
            }

            // this is to enhance the number of books imported

            
            for (int i=0;i<book_count; i++)
            {
                string[] split_line = book_info[i].Split('*');

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = sqlCon;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = @id";
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@id", int.Parse(split_line[0]));
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE TBL_BOOK SET QUANTITY = @quan WHERE ID = @id";
                    int current = dr.GetInt32(8);
                    int more = int.Parse(split_line[3]);
                    dr.Close();

                    int sum_quan = current + more;
                    cmd.Parameters.AddWithValue("@quan", sum_quan);
                    cmd.Parameters.AddWithValue("@id", int.Parse(split_line[0]));
                    cmd.ExecuteNonQuery();
                }
                dr.Close();            
            }

            sqlCon.Close();

            MessageBox.Show("Import books successfully", "Notification");
            ClearFlowPanel();

            ReloadAfterPurchase();
        }
        //this is the same with load initial
        public void ReloadAfterPurchase()
        {
            book_count = 0;

            sum_total = 0;

            lbl_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");

            //get emp info
            sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP WHERE ID = " + parent_form.emp_id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_em_name.Text = dr.GetString(2);
                lbl_code.Text = dr.GetInt32(0).ToString();
            }
            dr.Close();
            sqlCon.Close();

            LoadBookIdCBB();
            LoadBookNameCBB();
        }

        //Clear the flow panel before loading new ele
        public void ClearFlowPanel()
        {
            fpnl_detail.SuspendLayout();

            if (fpnl_detail.Controls.Count > 0)
            {
                for (int i = (fpnl_detail.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = fpnl_detail.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            fpnl_detail.ResumeLayout();
        }
    }
}

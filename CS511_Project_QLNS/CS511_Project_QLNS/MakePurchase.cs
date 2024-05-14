using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class MakePurchase : Form
    {
        Form1 parent_form;
        Uct_Customer_Cart parent_uct;

        connection con = new connection();
        string connect;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public string[] book_info; //book_info contains name, ex_price, quantity

        public MakePurchase(Form1 form1, Uct_Customer_Cart uct_Customer_Cart)
        {
            InitializeComponent();

            parent_form = form1;
            parent_uct = uct_Customer_Cart;

            lbl_total.Text = parent_uct.sumprice;

            connect = con.connect;
            sqlCon = new SqlConnection(connect);


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
            btn_exit.BackgroundImage= Properties.Resources.Cross2_image;

        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (txt_name.Texts != "" && txt_address.Texts!="" && txt_email.Texts!="" && txt_visa.Texts !="" && txt_secure.Texts!="")
            {
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                string name = txt_name.Texts;
                int money = int.Parse(lbl_total.Text.Replace(",",""));

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //save the receipt to the TBL_CUS_RECEIPT
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO TBL_CUS_RECEIPT (C_DATE, USERNAME, TOTAL) VALUES (@date, @name, @money)";
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue ("@name", name);
                cmd.Parameters.AddWithValue("@money", money);
                cmd.ExecuteNonQuery();

                //get id of the TBL_CUS_RECEIPT
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(ID_REC) FROM TBL_CUS_RECEIPT";
                int id_rec = (int)cmd.ExecuteScalar();

                for (int i=0; i <parent_form.cart_count; i++)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandType = CommandType.Text;
                }

                GetBookInfo();
                MinusBookQuantity();

                if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                for (int i=0;i<parent_form.cart_count;i++)
                {
                    string[] split_line = parent_form.cart_info[i].Split('*');
                    string[] split_book = book_info[i].Split('*');
                    cmd = new SqlCommand();
                    cmd.Connection = sqlCon;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO TBL_REC_DETAIL VALUES (@id_rec, @id_book, @name, @price, @quantity, @total)";
                    cmd.Parameters.AddWithValue("@id_rec",id_rec);
                    cmd.Parameters.AddWithValue("@id_book", split_line[0]);
                    cmd.Parameters.AddWithValue("@name", split_book[0]);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(split_book[1]));///
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(split_line[1]));

                    decimal book_price = decimal.Parse(split_book[1]);
                    int book_quan = int.Parse(split_line[1]);
                    int total = (int)book_price*book_quan;

                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();

                }

                sqlCon.Close();

                ClearFlowPanel();
                parent_form.cart_count = 0;

                MessageBox.Show("Thank you for your purchase","Congratulation");

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the blanks", "Sorry");
            }
        }

        public void GetBookInfo()
        {
            //get info of the books
            book_info = new string[200];


            for (int i = 0; i < parent_form.cart_count; i++)
            {
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                string[] split_line = parent_form.cart_info[i].Split('*');
                cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = " + split_line[0];
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    book_info[i] = dr.GetString(2) + "*" + dr.GetDecimal(6) + "*" + dr.GetInt32(8); 
                }
                sqlCon.Close();

            }
        }

        public void MinusBookQuantity()
        {

            for (int i = 0; i < parent_form.cart_count; i++)
            {
                if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;

                string[] split_line = parent_form.cart_info[i].Split('*');
                string[] split_l = book_info[i].Split('*');
                int taken = int.Parse(split_line[1]);
                int has = int.Parse(split_l[2]);

                int remain = has - taken;

                cmd.CommandText = "UPDATE TBL_BOOK SET QUANTITY = @remain WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@remain", remain);
                cmd.Parameters.AddWithValue("@ID", int.Parse(split_line[0]));
                cmd.ExecuteNonQuery();

                sqlCon.Close();

            }
        }

        //Clear the flow panel before loading new ele
        private void ClearFlowPanel()
        {
            parent_uct.fpnl.SuspendLayout();

            if (parent_uct.fpnl.Controls.Count > 0)
            {
                for (int i = (parent_uct.fpnl.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = parent_uct.fpnl.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            parent_uct.fpnl.ResumeLayout();
        }
    }
}

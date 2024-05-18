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
    public partial class Uct_Emp_Book : UserControl
    {
        Uct_Employee_Home parent_uct;
        Form2 parent_form;

        public int id;
        public string title
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value;}
        }
        public string author
        {
            get { return lbl_author.Text; }
            set { lbl_author.Text = value; }
        }
        public Image img
        {
            get
            {
                return ptb_img.BackgroundImage;
            }
            set
            {
                ptb_img.BackgroundImage = value;
            }
        }
        public Uct_Emp_Book()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image img, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.img = img;
        }

        private void Uct_Emp_Book_Click(object sender, EventArgs e)
        {
            var pa = this.Parent.Parent;
            parent_uct = (Uct_Employee_Home)pa;

            var pa_pa = parent_uct.Parent;
            parent_form = (Form2)pa_pa;

            SqlConnection sqlCon = new SqlConnection(parent_uct.connect);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = " + id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Emp_BookInfo book = new Emp_BookInfo();
                System.Drawing.Image img = System.Drawing.Image.FromFile(parent_uct.local_dir + dr.GetString(1) + ".png");
                book.LoadData(dr.GetInt32(0), img, dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDecimal(5).ToString("0.##"), dr.GetDecimal(6).ToString("0.##"), dr.GetString(7), dr.GetInt32(8).ToString());

                parent_form.Hide();
                book.ShowDialog();

                parent_form.Show();
            }
        }

        private void ptb_img_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_author_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void ptb_edit_Click(object sender, EventArgs e)
        {
            var pa = this.Parent.Parent;
            parent_uct = (Uct_Employee_Home) pa;

            var pa_pa = pa.Parent;
            parent_form = (Form2)pa_pa;

            SqlConnection sqlCon = new SqlConnection(parent_uct.connect);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = " + id;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Emp_BookEdit book_edit = new Emp_BookEdit();
                System.Drawing.Image img = System.Drawing.Image.FromFile(parent_uct.local_dir + dr.GetString(1) + ".png");
                book_edit.LoadData(dr.GetInt32(0), img, dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDecimal(5).ToString("0.##"), dr.GetDecimal(6).ToString("0.##"), dr.GetString(7), dr.GetInt32(8).ToString());

                parent_form.Hide();
                book_edit.ShowDialog();

                parent_form.Show();
            }

        }
    }
}

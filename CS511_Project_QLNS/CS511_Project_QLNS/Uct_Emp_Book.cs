﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        Uct_Emp_BookSearch parent_uct;
        Form2 parent_form;

        private int lineThickness = 1; // Adjust for desired line thickness
        private Color lineColor = Color.Black; // 

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
            connection co = new connection();

            SqlConnection sqlCon = new SqlConnection(co.connect);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = " + id;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Emp_BookInfo book = new Emp_BookInfo();
                System.Drawing.Image img = System.Drawing.Image.FromFile(co.local_dir + dr.GetString(1) + ".png");
                book.LoadData(dr.GetInt32(0), img, dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDecimal(5).ToString("0.##"), dr.GetDecimal(6).ToString("0.##"), dr.GetString(7), dr.GetInt32(8).ToString());
                sqlCon.Close();

                book.ShowDialog();
            }
            dr.Close();
            sqlCon.Close();
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
            parent_uct = (Uct_Emp_BookSearch)pa;

            SqlConnection sqlCon = new SqlConnection(parent_uct.connect);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK WHERE ID = " + id;

            SqlDataReader dr = cmd.ExecuteReader();

            Emp_BookEdit book_edit = new Emp_BookEdit();
            System.Drawing.Image img1 = System.Drawing.Image.FromFile("icon_picture.png");

            if (dr.Read())
            {
                ptb_img.BackgroundImage.Dispose();
                ptb_img.BackgroundImage = null;

                FileInfo file = new FileInfo(parent_uct.local_dir + dr.GetString(1) + ".png");
                file.CopyTo("bpic.png", true);
                img1 = System.Drawing.Image.FromFile("bpic.png");

                book_edit.LoadData(dr.GetInt32(0), img1, dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetDecimal(5).ToString("0.##"), dr.GetDecimal(6).ToString("0.##"), dr.GetString(7), dr.GetInt32(8).ToString());
            }
            dr.Close();
            sqlCon.Close();

            book_edit.ShowDialog();
            img1.Dispose();

            parent_uct.DisposePictureBoxImages();
            parent_uct.ClearFlowPanel();
            if (parent_uct.is_displayed_button == 0)
                parent_uct.LoadData();
            else
                parent_uct.LoadDataWithCate(parent_uct.is_displayed_button.ToString());

        }

        private void ptb_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to remove this permanently", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var pa = this.Parent.Parent;
                parent_uct = (Uct_Emp_BookSearch)pa;

                //get the fpnl_books in parent_uct
                Control fpnl = FindControlByName(parent_uct, "fpnl_books");

                ptb_img.BackgroundImage.Dispose();

                //remove this control out of the fpnl
                fpnl.Controls.Remove(this);

                //delete this book from db
                SqlConnection sqlCon = new SqlConnection(parent_uct.connect);
                if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM TBL_BOOK WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();
            }
            else if (result == DialogResult.No)
            {
                // User clicked No
                // Perform actions for No click
                return;
            }
        }

        Control FindControlByName(Control control, string controlName)
        {
            if (control.Name == controlName)
            {
                return control;
            }

            foreach (Control childControl in control.Controls)
            {
                Control foundControl = FindControlByName(childControl, controlName);
                if (foundControl != null)
                {
                    return foundControl;
                }
            }
            return null;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Draw the line using preferred placement and thickness
            e.Graphics.DrawRectangle(new Pen(lineColor, lineThickness), 0, 0, this.Width - 1, this.Height - 1);
        }

        private void Uct_Emp_Book_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.WhiteSmoke;
        }

        private void Uct_Emp_Book_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void ptb_img_MouseEnter(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseEnter(sender, e);
        }

        private void ptb_img_MouseLeave(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseLeave(sender, e);
        }

        private void lbl_name_MouseEnter(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseEnter(sender, e);
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseLeave(sender, e);
        }

        private void ptb_edit_MouseEnter(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseEnter(sender, e);
        }

        private void ptb_edit_MouseLeave(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseLeave(sender, e);
        }

        private void ptb_delete_MouseEnter(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseEnter(sender, e);
        }

        private void ptb_delete_MouseLeave(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseLeave(sender, e);

        }

        private void lbl_author_MouseLeave(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseLeave(sender, e);
        }

        private void lbl_author_MouseEnter(object sender, EventArgs e)
        {
            Uct_Emp_Book_MouseEnter(sender, e);
        }
    }
}

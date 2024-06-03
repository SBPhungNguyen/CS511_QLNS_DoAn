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
    public partial class Uct_Employee_Cashier : UserControl
    {
        connection co = new connection();
        public string connect;
        public string pic_dir;
        SqlConnection sqlCon;
        SqlCommand cmd;

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        public int is_displayed_button;
        public Uct_Employee_Cashier()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            pic_dir = co.emp_dir;

            is_displayed_button = 0;
            btn_all.BackColor = color_btn_cate_chosen;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;

            cbb_type.SelectedIndex = 0;

            LoadData();
        }
        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Uct_Emp_Cashier uct = new Uct_Emp_Cashier();
                Image img = System.Drawing.Image.FromFile( pic_dir + dr.GetString(1)+".png");
                uct.LoadData(dr.GetInt32(0), img, dr.GetString(2), dr.GetString(5));
                fpnl_emp.Controls.Add(uct);
            }
            dr.Close();
            sqlCon.Close();
        }
        public void LoadDataWithCate(string cate)
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP WHERE E_ROLE = @cate";
            cmd.Parameters.AddWithValue("@cate", cate);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Uct_Emp_Cashier uct = new Uct_Emp_Cashier();
                Image img = System.Drawing.Image.FromFile(pic_dir + dr.GetString(1) + ".png");
                uct.LoadData(dr.GetInt32(0), img, dr.GetString(2), dr.GetString(5));
                fpnl_emp.Controls.Add(uct);
            }
            dr.Close();
            sqlCon.Close();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            is_displayed_button = 0;
            DisposeUserControlPictures();
            //DisposePictureBoxImages();
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_chosen;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_normal;
            LoadData();
        }

        private void btn_cat1_Click(object sender, EventArgs e)
        {
            is_displayed_button = 1;
            DisposeUserControlPictures();
            //DisposePictureBoxImages();
            ClearFlowPanel();
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_chosen;
            btn_cat2.BackColor = color_btn_cate_normal;
            LoadDataWithCate("1");

        }

        private void btn_cat2_Click(object sender, EventArgs e)
        {
            DisposeUserControlPictures();
            //DisposePictureBoxImages();
            ClearFlowPanel();
            is_displayed_button = 2;
            btn_all.BackColor = color_btn_cate_normal;
            btn_cat1.BackColor = color_btn_cate_normal;
            btn_cat2.BackColor = color_btn_cate_chosen;
            LoadDataWithCate("0");
        }

        //Clear the flow panel before loading new ele
        public void ClearFlowPanel()
        {
            fpnl_emp.SuspendLayout();

            if (fpnl_emp.Controls.Count > 0)
            {
                for (int i = (fpnl_emp.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = fpnl_emp.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            fpnl_emp.ResumeLayout();
        }

        public void DisposeUserControlPictures()
        {
            if (fpnl_emp.Controls.Count > 0)
            {
                foreach (Control control in fpnl_emp.Controls)
                {
                    // Check if control is a UserControl
                    if (control is UserControl userControl)
                    {
                        // Dispose pictures within the UserControl (pass the user control)
                        DisposeUserControlPictures(userControl);
                    }
                    else
                    {
                        // Check if control is a PictureBox directly in the FlowLayoutPanel
                        if (control is PictureBox pictureBox)
                        {
                            DisposePictureBoxImage(pictureBox);
                        }
                    }
                }
            }
        }

        private void DisposePictureBoxImage(PictureBox pictureBox)
        {
            // Check if PictureBox has a background image
            if (pictureBox.BackgroundImage != null)
            {
                pictureBox.BackgroundImage.Dispose();
                pictureBox.BackgroundImage = null;
            }

            // Check if PictureBox has an image directly loaded (optional)
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        // Assuming you have this function in your user control code
        private void DisposeUserControlPictures(UserControl userControl)
        {
            // Iterate through controls in the UserControl
            foreach (Control control in userControl.Controls)
            {
                // Check for PictureBoxes within the UserControl
                if (control is PictureBox pictureBox)
                {
                    DisposePictureBoxImage(pictureBox);
                }
                // You can add logic to handle nested UserControls here (optional)
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form2 parent = this.Parent as Form2;
            Emp_CashierAdd emp = new Emp_CashierAdd();
            parent.Hide();
            emp.ShowDialog();

            DisposeUserControlPictures();
            //DisposePictureBoxImages();
            ClearFlowPanel();
            if (is_displayed_button == 0)
                LoadData();
            else
                LoadDataWithCate(is_displayed_button.ToString());
            parent.Show();
        }

        private void ptb_Search_Click(object sender, EventArgs e)
        {
            if (is_displayed_button == 0)
                SearchWithAll();
            else
                SearchWithCate(is_displayed_button%2);
        }
        public void SearchWithAll()
        {
            int type = cbb_type.SelectedIndex;
            if (txt_search.Texts == "")
            {
                MessageBox.Show("Please enter the string you want to search", "No string found");
                return;
            }
            if (type == 0)
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_EMP";

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetInt32(0).ToString().ToLower().Contains(txt_search.Texts.ToLower()) || rd.GetString(2).ToLower().Contains(txt_search.Texts.ToLower()) || rd.GetString(3).ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
            else if (type == 1)
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_EMP";

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetInt32(0).ToString().ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
            else if (type==2)
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * FROM TBL_EMP";

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetString(2).ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
            else
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * FROM TBL_EMP";

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetString(3).ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
        }
        public void SearchWithCate(int cate)
        {
            int type = cbb_type.SelectedIndex;
            if (txt_search.Texts == "")
            {
                MessageBox.Show("Please enter the string you want to search", "No string found");
                return;
            }
            if (type == 0)
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_EMP WHERE E_ROLE = " + cate;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetInt32(0).ToString().Contains(txt_search.Texts.ToLower()) || rd.GetString(2).ToLower().Contains(txt_search.Texts.ToLower()) || rd.GetString(3).ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
            else if (type == 1)
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_EMP WHERE E_ROLE = " + cate;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetInt32(0).ToString().Contains(txt_search.Texts))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
            else if (type ==2)
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_EMP WHERE E_ROLE = " + cate;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetString(2).ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
            else
            {
                DisposeUserControlPictures();

                ClearFlowPanel();
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from TBL_EMP WHERE E_ROLE = " + cate;

                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetString(3).ToLower().Contains(txt_search.Texts.ToLower()))
                    {
                        Uct_Emp_Cashier book = new Uct_Emp_Cashier();
                        Image img = System.Drawing.Image.FromFile(co.emp_dir + rd.GetString(1) + ".png");

                        book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetString(3));
                        fpnl_emp.Controls.Add(book);
                    }
                }
                sqlCon.Close();
            }
        }
    }
}

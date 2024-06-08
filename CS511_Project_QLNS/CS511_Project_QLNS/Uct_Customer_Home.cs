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
    public partial class Uct_Customer_Home : UserControl
    {
        connection con = new connection();
        string connect;

        public SqlConnection sqlCon;
        public string local_dir;

        public Color color_btn_cate_normal = Color.Green;
        public Color color_btn_cate_chosen = Color.FromArgb(0, 181, 0);

        public int is_displayed_button;

        public Uct_Customer_Home()
        {
            InitializeComponent();
            //fpnl_books.WrapContents = true; 
            //fpnl_books.AutoScroll = true;

            //cbb_type.SelectedIndex = 0;

            //local_dir = con.local_dir;

            ////establish the sqlCon for db
            //connect = con.connect;
            //sqlCon = new SqlConnection(connect);

            //btn_all.BackColor = color_btn_cate_chosen;
            //is_displayed_button = 0;
            //LoadData();

            fpnl_item.WrapContents = true;
            fpnl_item.AutoScroll = true;
            Uct_Cus_Adv uct_Cus_Adv = new Uct_Cus_Adv();
            uct_Cus_Adv.Name = "uct_Cus_Adv";
            fpnl_item.Controls.Add(uct_Cus_Adv);
            Uct_Customer_BookSearch uct_Customer_BookSearch = new Uct_Customer_BookSearch();
            uct_Customer_BookSearch.Name = "uct_Customer_BookSearch";
            fpnl_item.Controls.Add(uct_Customer_BookSearch);
            Uct_Cus_HomeInfo uct_Cus_HomeInfo = new Uct_Cus_HomeInfo();
            uct_Cus_HomeInfo.Name = "uct_Cus_HomeInfo";
            fpnl_item.Controls.Add(uct_Cus_HomeInfo);
        }

        //public void LoadData()
        //{
        //    if (sqlCon.State == ConnectionState.Closed)
        //        sqlCon.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = sqlCon;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "Select * from TBL_BOOK";

        //    SqlDataReader rd = cmd.ExecuteReader();

        //    while (rd.Read())
        //    {
        //        Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //        Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //        uct_Cus_Book.LoadData(rd.GetInt32(0),img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //        fpnl_books.Controls.Add(uct_Cus_Book);
        //    }

        //    sqlCon.Close();
        //}

        //public void LoadDataWithCate(string cate)
        //{
        //    if (sqlCon.State == ConnectionState.Closed)
        //        sqlCon.Open();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = sqlCon;
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "Select * from TBL_BOOK WHERE GENRE = "+cate;

        //    SqlDataReader rd = cmd.ExecuteReader();

        //    while (rd.Read())
        //    {
        //        Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //        Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //        uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //        fpnl_books.Controls.Add(uct_Cus_Book);
        //    }

        //    sqlCon.Close();
        //}


        ////Clear the flow panel before loading new ele
        //private void ClearFlowPanel()
        //{
        //    fpnl_books.SuspendLayout();

        //    if (fpnl_books.Controls.Count > 0)
        //    {
        //        for (int i = (fpnl_books.Controls.Count - 1); i >= 0; i--)
        //        {
        //            Control c = fpnl_books.Controls[i];
        //            c.Dispose();
        //        }
        //        GC.Collect();
        //    }
        //    fpnl_books.ResumeLayout();
        //}

        //private void btn_all_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_chosen;
        //    btn_cat1.BackColor = color_btn_cate_normal;
        //    btn_cat2.BackColor = color_btn_cate_normal;
        //    btn_cat3.BackColor = color_btn_cate_normal;
        //    btn_cat4.BackColor = color_btn_cate_normal;
        //    btn_cat5.BackColor = color_btn_cate_normal;
        //    btn_cat6.BackColor = color_btn_cate_normal;

        //    is_displayed_button = 0;
        //    LoadData();
        //}

        //private void btn_cat1_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_normal;
        //    btn_cat1.BackColor = color_btn_cate_chosen;
        //    btn_cat2.BackColor = color_btn_cate_normal;
        //    btn_cat3.BackColor = color_btn_cate_normal;
        //    btn_cat4.BackColor = color_btn_cate_normal;
        //    btn_cat5.BackColor = color_btn_cate_normal;
        //    btn_cat6.BackColor = color_btn_cate_normal;

        //    is_displayed_button = 1;
        //    LoadDataWithCate("1");

        //}


        //private void btn_cat2_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_normal;
        //    btn_cat1.BackColor = color_btn_cate_normal;
        //    btn_cat2.BackColor = color_btn_cate_chosen;
        //    btn_cat3.BackColor = color_btn_cate_normal;
        //    btn_cat4.BackColor = color_btn_cate_normal;
        //    btn_cat5.BackColor = color_btn_cate_normal;
        //    btn_cat6.BackColor = color_btn_cate_normal;

        //    is_displayed_button = 2;
        //    LoadDataWithCate("2");
        //}

        //private void btn_cat3_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_normal;
        //    btn_cat1.BackColor = color_btn_cate_normal;
        //    btn_cat2.BackColor = color_btn_cate_normal;
        //    btn_cat3.BackColor = color_btn_cate_chosen;
        //    btn_cat4.BackColor = color_btn_cate_normal;
        //    btn_cat5.BackColor = color_btn_cate_normal;
        //    btn_cat6.BackColor = color_btn_cate_normal; 
            
        //    is_displayed_button = 3;
        //    LoadDataWithCate("3");
        //}

        //private void btn_cat4_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_normal;
        //    btn_cat1.BackColor = color_btn_cate_normal;
        //    btn_cat2.BackColor = color_btn_cate_normal;
        //    btn_cat3.BackColor = color_btn_cate_normal;
        //    btn_cat4.BackColor = color_btn_cate_chosen;
        //    btn_cat5.BackColor = color_btn_cate_normal;
        //    btn_cat6.BackColor = color_btn_cate_normal;

        //    is_displayed_button = 4;
        //    LoadDataWithCate("4");
        //}

        //private void btn_cat5_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_normal;
        //    btn_cat1.BackColor = color_btn_cate_normal;
        //    btn_cat2.BackColor = color_btn_cate_normal;
        //    btn_cat3.BackColor = color_btn_cate_normal;
        //    btn_cat4.BackColor = color_btn_cate_normal;
        //    btn_cat5.BackColor = color_btn_cate_chosen;
        //    btn_cat6.BackColor = color_btn_cate_normal;

        //    is_displayed_button = 5;
        //    LoadDataWithCate("5");
        //}

        //private void btn_cat6_Click(object sender, EventArgs e)
        //{
        //    ClearFlowPanel();
        //    btn_all.BackColor = color_btn_cate_normal;
        //    btn_cat1.BackColor = color_btn_cate_normal;
        //    btn_cat2.BackColor = color_btn_cate_normal;
        //    btn_cat3.BackColor = color_btn_cate_normal;
        //    btn_cat4.BackColor = color_btn_cate_normal;
        //    btn_cat5.BackColor = color_btn_cate_normal;
        //    btn_cat6.BackColor = color_btn_cate_chosen;

        //    is_displayed_button = 6;
        //    LoadDataWithCate("6");
        //}

        //private void ptb_Search_Click(object sender, EventArgs e)
        //{
        //    if (is_displayed_button == 0)
        //        SearchWithAll();
        //    else
        //        SearchWithCate(is_displayed_button);
        //}

        //public void SearchWithAll()
        //{
        //    int type = cbb_type.SelectedIndex;
        //    if (txt_search.Texts == "")
        //    {
        //        MessageBox.Show("Please enter the string you want to search","No string found");
        //        return;
        //    }
        //    if (type == 0)
        //    {
        //        ClearFlowPanel();
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = sqlCon;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from TBL_BOOK";

        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            if (rd.GetString(2).Contains(txt_search.Texts) || rd.GetString(3).Contains(txt_search.Texts))
        //            {
        //                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //                fpnl_books.Controls.Add(uct_Cus_Book);
        //            }
        //        }
        //        sqlCon.Close();
        //    }
        //    else if (type == 1)
        //    {
        //        ClearFlowPanel();
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = sqlCon;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from TBL_BOOK";

        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            if (rd.GetString(2).Contains(txt_search.Texts))
        //            {
        //                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //                fpnl_books.Controls.Add(uct_Cus_Book);
        //            }
        //        }
        //        sqlCon.Close();
        //    }
        //    else
        //    {
        //        ClearFlowPanel();
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = sqlCon;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from TBL_BOOK";

        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            if (rd.GetString(3).Contains(txt_search.Texts))
        //            {
        //                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //                fpnl_books.Controls.Add(uct_Cus_Book);
        //            }
        //        }
        //        sqlCon.Close();
        //    }
        //}

        //public void SearchWithCate(int cate)
        //{
        //    int type = cbb_type.SelectedIndex;
        //    if (txt_search.Texts == "")
        //    {
        //        MessageBox.Show("Please enter the string you want to search", "No string found");
        //        return;
        //    }
        //    if (type == 0)
        //    {
        //        ClearFlowPanel();
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = sqlCon;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from TBL_BOOK WHERE GENRE = "+cate;

        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            if (rd.GetString(2).Contains(txt_search.Texts) || rd.GetString(3).Contains(txt_search.Texts))
        //            {
        //                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //                fpnl_books.Controls.Add(uct_Cus_Book);
        //            }
        //        }
        //        sqlCon.Close();
        //    }
        //    else if (type == 1)
        //    {
        //        ClearFlowPanel();
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = sqlCon;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from TBL_BOOK WHERE GENRE = " + cate;

        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            if (rd.GetString(2).Contains(txt_search.Texts))
        //            {
        //                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //                fpnl_books.Controls.Add(uct_Cus_Book);
        //            }
        //        }
        //        sqlCon.Close();
        //    }
        //    else
        //    {
        //        ClearFlowPanel();
        //        if (sqlCon.State == ConnectionState.Closed)
        //            sqlCon.Open();

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = sqlCon;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "Select * from TBL_BOOK WHERE GENRE = " + cate;

        //        SqlDataReader rd = cmd.ExecuteReader();

        //        while (rd.Read())
        //        {
        //            if (rd.GetString(3).Contains(txt_search.Texts))
        //            {
        //                Uct_Cus_Book uct_Cus_Book = new Uct_Cus_Book();
        //                Image img = System.Drawing.Image.FromFile(local_dir + rd.GetString(1) + ".png");

        //                uct_Cus_Book.LoadData(rd.GetInt32(0), img, rd.GetString(2), rd.GetDecimal(6).ToString("0.##"), rd.GetInt32(8));
        //                fpnl_books.Controls.Add(uct_Cus_Book);
        //            }
        //        }
        //        sqlCon.Close();
        //    }
        //}

        //public void DisposePictureBoxImages()
        //{
        //    if (fpnl_books.Controls.Count > 0)
        //    {
        //        foreach (Control control in fpnl_books.Controls)
        //        {
        //            // Check if control is a UserControl
        //            if (control is UserControl userControl)
        //            {
        //                // Dispose pictures within the UserControl (pass the user control)
        //                DisposeUserControlPictures(userControl);
        //            }
        //            else
        //            {
        //                // Check if control is a PictureBox directly in the FlowLayoutPanel
        //                if (control is PictureBox pictureBox)
        //                {
        //                    DisposePictureBoxImage(pictureBox);
        //                }
        //            }
        //        }
        //    }
        //}

        //private void DisposePictureBoxImage(PictureBox pictureBox)
        //{
        //    // Check if PictureBox has a background image
        //    if (pictureBox.BackgroundImage != null)
        //    {
        //        pictureBox.BackgroundImage.Dispose();
        //        pictureBox.BackgroundImage = null;
        //    }

        //    // Check if PictureBox has an image directly loaded (optional)
        //    if (pictureBox.Image != null)
        //    {
        //        pictureBox.Image.Dispose();
        //        pictureBox.Image = null;
        //    }
        //}

        //// Assuming you have this function in your user control code
        //private void DisposeUserControlPictures(UserControl userControl)
        //{
        //    // Iterate through controls in the UserControl
        //    foreach (Control control in userControl.Controls)
        //    {
        //        // Check for PictureBoxes within the UserControl
        //        if (control is PictureBox pictureBox)
        //        {
        //            DisposePictureBoxImage(pictureBox);
        //        }
        //        // You can add logic to handle nested UserControls here (optional)
        //    }
        //}
    }
}

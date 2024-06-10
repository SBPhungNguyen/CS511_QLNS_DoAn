using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Emp_Adv : UserControl
    {
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Image big_img
        {
            get { return ptb_bigimg.BackgroundImage; }
            set { ptb_bigimg.BackgroundImage = value; }
        }
        public Image small_img_up
        {
            get { return ptb_smallimg1.BackgroundImage; }
            set { ptb_smallimg1.BackgroundImage = value; }
        }
        public Image small_img_down
        {
            get { return ptb_smallimg2.BackgroundImage; }
            set { ptb_smallimg2.BackgroundImage = value; }
        }
        public Uct_Emp_Adv()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
            LoadData();
        }
        public void LoadData()
        {
            ptb_bigimg.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "c.png");
            ptb_smallimg1.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "a.png");
            ptb_smallimg2.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "b.png");
        }
        public void DisposePic()
        {
            ptb_bigimg.BackgroundImage.Dispose();
            ptb_smallimg1.BackgroundImage.Dispose();
            ptb_smallimg2.BackgroundImage.Dispose();
        }

        private void ptb_bigimg_Click(object sender, EventArgs e)
        {
            Emp_Adv_Control emp_Adv_Control = new Emp_Adv_Control("c");
            ptb_bigimg.BackgroundImage.Dispose();
            emp_Adv_Control.ShowDialog();
            ptb_bigimg.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "c.png");
        }

        private void ptb_smallimg1_Click(object sender, EventArgs e)
        {
            Emp_Adv_Control emp_Adv_Control = new Emp_Adv_Control("a");
            ptb_smallimg1.BackgroundImage.Dispose();
            emp_Adv_Control.ShowDialog();
            ptb_smallimg1.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "a.png");
        }

        private void ptb_smallimg2_Click(object sender, EventArgs e)
        {
            Emp_Adv_Control emp_Adv_Control = new Emp_Adv_Control("b");
            ptb_smallimg2.BackgroundImage.Dispose();
            emp_Adv_Control.ShowDialog();
            ptb_smallimg2.BackgroundImage = System.Drawing.Image.FromFile(co.emp_dir + "b.png");
        }
    }
}

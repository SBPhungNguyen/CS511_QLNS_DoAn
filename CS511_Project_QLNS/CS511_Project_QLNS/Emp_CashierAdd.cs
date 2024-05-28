using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Emp_CashierAdd : Form
    {
        FileInfo file;
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        string pic_dir;
        public Emp_CashierAdd()
        {
            InitializeComponent();
            file = new FileInfo("icon_picture.png");
            sqlCon = new SqlConnection(co.connect);
            pic_dir = co.emp_dir;
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

        private void ptb_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Picture (.png) | *.png";
            dlg.Multiselect = false;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptb_img.BackgroundImage = System.Drawing.Image.FromFile(dlg.FileName);
                file = new FileInfo(dlg.FileName);
            }
        }
    }
}

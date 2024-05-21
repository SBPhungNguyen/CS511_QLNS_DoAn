using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Emp_BookAdd : Form
    {
        Form2 parent_form;
        public Emp_BookAdd(Form2 parent)
        {
            InitializeComponent();
            parent_form = parent;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ptb_img.BackgroundImage.Dispose();
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
    }
}

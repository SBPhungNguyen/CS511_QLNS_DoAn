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
    public partial class Uct_Emp_Cashier : UserControl
    {
        public int id;
        public Uct_Emp_Cashier()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image pic, string name, string role)
        {
            this.id = id;
            ptb_img.BackgroundImage = pic;
            lbl_name.Text = name;
            if (role == "0")
            {
                lbl_role.Text = "Cashier";
            }
            else
                lbl_role.Text = "Manager";
        }

        private void Uct_Emp_Cashier_Click(object sender, EventArgs e)
        {
            Form2 form = this.Parent.Parent.Parent as Form2;
            Emp_CashierInfo emp = new Emp_CashierInfo(id);
            form.Hide();

            emp.ShowDialog();
            form.Show();
        }

        private void ptb_img_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_role_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void ptb_update_Click(object sender, EventArgs e)
        {
            Form2 parent = this.Parent.Parent.Parent as Form2;
            Uct_Employee_Cashier parent_uct = this.Parent.Parent as Uct_Employee_Cashier;

            ptb_img.BackgroundImage.Dispose();
            parent.emp_img.Dispose();
            Emp_CashierEdit edit = new Emp_CashierEdit(id, parent);

            parent.Hide();
            edit.ShowDialog();

            //parent_uct.DisposePictureBoxImages();
            parent_uct.DisposeUserControlPictures();
            parent_uct.ClearFlowPanel();
            if (parent_uct.is_displayed_button == 0)
                parent_uct.LoadData();
            else
                parent_uct.LoadDataWithCate(parent_uct.is_displayed_button.ToString());

            parent.Show();
        }
    }
}

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
using ZXing.OneD;

namespace CS511_Project_QLNS
{
    public partial class Uct_Emp_Cashier : UserControl
    {
        public int id;
        private int lineThickness = 1; // Adjust for desired line thickness
        private Color lineColor = Color.Black; // 
        public Uct_Emp_Cashier()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image pic, string name, string role)
        {
            this.id = id;
            lbl_id.Text = id.ToString();
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
            //form.Hide();

            emp.ShowDialog();
            //form.Show();
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

            //parent.Hide();
            edit.ShowDialog();

            //parent_uct.DisposePictureBoxImages();
            parent_uct.DisposeUserControlPictures();
            parent_uct.ClearFlowPanel();
            if (parent_uct.is_displayed_button == 0)
                parent_uct.LoadData();
            else
                parent_uct.LoadDataWithCate(parent_uct.is_displayed_button.ToString());

            //parent.Show();
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

        private void ptb_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to remove this permanently", "Warning", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form2 parent = this.Parent.Parent.Parent as Form2;
                Uct_Employee_Cashier parent_uct = this.Parent.Parent as Uct_Employee_Cashier;

                if (parent.emp_id == this.id)
                {
                    MessageBox.Show("Cannot delete this user as it's the current user", "Opps");
                    return;
                }

                //get the fpnl_emp in parent_uct
                Control fpnl = FindControlByName(parent_uct, "fpnl_emp");

                //dispose the pic of this uct
                ptb_img.BackgroundImage.Dispose();

                //remove this control out of the fpnl
                fpnl.Controls.Remove(this);

                //delete this book from db
                connection co = new connection();
                SqlConnection sqlCon = new SqlConnection(co.connect);
                SqlCommand cmd = new SqlCommand();
                if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM TBL_EMP WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.ExecuteNonQuery();
            }
            else if (result == DialogResult.No)
            {
                // User clicked No
                // Perform actions for No click
                return;
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Draw the line using preferred placement and thickness
            e.Graphics.DrawRectangle(new Pen(lineColor, lineThickness), 0, 0, this.Width - 1, this.Height - 1);
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {
            this.OnClick(null);

        }

    }
}

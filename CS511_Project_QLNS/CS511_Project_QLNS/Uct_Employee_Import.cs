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
    public partial class Uct_Employee_Import : UserControl
    {
        public Uct_Employee_Import()
        {
            InitializeComponent();
            fpnl_import.WrapContents = true;
            fpnl_import.AutoScroll = true;

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form2 parent_form;
            var pa = this.ParentForm;
            parent_form = pa as Form2;

            Emp_ImportAdd emp_ImportAdd = new Emp_ImportAdd();
            parent_form.Hide();

            emp_ImportAdd.ShowDialog();

            parent_form.Show();
        }
    }
}

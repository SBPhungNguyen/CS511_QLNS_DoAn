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
    public partial class Uct_Emp_Import : UserControl
    {
        public Uct_Emp_Import()
        {
            InitializeComponent();
        }
        public void LoadData(int id, string name, string date, string money)
        {
            lbl_id.Text = id.ToString();
            lbl_name.Text = name;
            lbl_date.Text = date;    
            lbl_sum.Text = money;
        }

        private void Uct_Emp_Import_Click(object sender, EventArgs e)
        {
            Emp_ImportInfo emp_ImportInfo = new Emp_ImportInfo(lbl_id.Text);
            emp_ImportInfo.ShowDialog();
        }

        private void lbl_sum_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void customPanel1_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }
    }
}

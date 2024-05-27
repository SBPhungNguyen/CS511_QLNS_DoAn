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
    }
}

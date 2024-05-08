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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //Uct_Employee_Home uct = new Uct_Employee_Home();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);
            Uct_Employee_Import uct = new Uct_Employee_Import();
            uct.Location = new System.Drawing.Point(235, 105);
            this.Controls.Add(uct);
        }
    }
}

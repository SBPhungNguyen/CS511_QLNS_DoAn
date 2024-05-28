using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class CalendarShow : Form
    {
        int type; //0: add emp, 1: edit emp
        Emp_CashierEdit parent_Edit;
        Emp_CashierAdd parent_Add;
        public CalendarShow(Emp_CashierAdd parent)
        {
            InitializeComponent();
            monthCalendar1.DateSelected += new DateRangeEventHandler(monthCalendar_DateSelected);
            type = 0;
            parent_Add = parent;
        }

        public CalendarShow(Emp_CashierEdit parent)
        {
            InitializeComponent();
            monthCalendar1.DateSelected += new DateRangeEventHandler(monthCalendar_DateSelected);
            type = 1;
            parent_Edit = parent;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = e.Start;
            // Do something with the selected date, e.g., display in a label
            if (type == 0)
            {
                parent_Add.b_date = selectedDate.ToShortDateString();
                this.Dispose();
                this.Close();
            }
            else
            {
                parent_Edit.b_date = selectedDate.ToShortDateString();
                this.Dispose();
                this.Close();
            }
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
    }
}

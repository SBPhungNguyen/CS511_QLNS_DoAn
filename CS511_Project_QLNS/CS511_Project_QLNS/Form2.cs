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
        connection co = new connection();
        public Color color_btn_normal = Color.FromArgb(24, 138, 93);
        public Color color_btn_chosen = Color.FromArgb(31, 181, 122);

        Uct_Employee_Home uct_Employee_Home;
        Uct_Employee_Import uct_Employee_Import;
        Uct_Employee_Report uct_Employee_Report;
        Uct_Employee_Chat uct_Employee_Chat;
        Uct_Employee_Cashier uct_Employee_Cashier;
        public Form2()
        {
            InitializeComponent();
            //Uct_Employee_Home uct = new Uct_Employee_Home();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);
            //Uct_Employee_Import uct = new Uct_Employee_Import();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //Uct_Employee_Report uct = new Uct_Employee_Report();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //Uct_Employee_Cashier uct = new Uct_Employee_Cashier();
            //uct.Location = new System.Drawing.Point(235, 105);
            //this.Controls.Add(uct);

            //if manager -> show employee, not -> don't show

            uct_Employee_Home = new Uct_Employee_Home();
            uct_Employee_Home.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Home.Name = "uct_Employee_Home";
            this.Controls.Add(uct_Employee_Home);
            uct_Employee_Home.BringToFront();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
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

        private void btn_home_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "HOME";

            btn_home.BackColor = color_btn_chosen;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_normal;

            uct_Employee_Home = new Uct_Employee_Home();
            uct_Employee_Home.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Home.Name = "uct_Employee_Home";
            this.Controls.Add(uct_Employee_Home);
            uct_Employee_Home.BringToFront();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "IMPORT";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_chosen;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_normal;

            uct_Employee_Import = new Uct_Employee_Import();
            uct_Employee_Import.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Import.Name = "uct_Employee_Import";
            this.Controls.Add(uct_Employee_Import);
            uct_Employee_Import.BringToFront();
        }
        private void btn_report_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "REPORT";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_chosen;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_normal;

            uct_Employee_Report = new Uct_Employee_Report();
            uct_Employee_Report.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Report.Name = "uct_Employee_Report";
            this.Controls.Add(uct_Employee_Report);
            uct_Employee_Report.BringToFront();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "CHAT";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_chosen;
            btn_employee.BackColor = color_btn_normal;

            uct_Employee_Chat = new Uct_Employee_Chat();
            uct_Employee_Chat.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Chat.Name = "uct_Employee_Chat";
            this.Controls.Add(uct_Employee_Chat);
            uct_Employee_Chat.BringToFront();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "EMPLOYEE";

            btn_home.BackColor = color_btn_normal;
            btn_import.BackColor = color_btn_normal;
            btn_report.BackColor = color_btn_normal;
            btn_chat.BackColor = color_btn_normal;
            btn_employee.BackColor = color_btn_chosen;

            uct_Employee_Cashier = new Uct_Employee_Cashier();
            uct_Employee_Cashier.Location = new System.Drawing.Point(235, 105);
            uct_Employee_Cashier.Name = "uct_Employee_Cashier";
            this.Controls.Add(uct_Employee_Cashier);
            uct_Employee_Cashier.BringToFront();
        }
    }
}

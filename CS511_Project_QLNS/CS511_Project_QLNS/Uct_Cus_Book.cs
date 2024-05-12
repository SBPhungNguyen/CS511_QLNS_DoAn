using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CS511_Project_QLNS
{
    public partial class Uct_Cus_Book : UserControl
    {
        public int id;
        public Image img
        {
            get {  return ptb_img.BackgroundImage; }
            set { ptb_img.BackgroundImage = value; }
        }
        public string title
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }
        public string price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }
        }
        public Uct_Cus_Book()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image pic, string title, string price)
        {
            this.id = id;
            ptb_img.BackgroundImage = pic;
            this.title = title;

            string formattedNumber = string.Format("{0:#,###}", int.Parse(price));
            this.price = formattedNumber;
        }

        private void Uct_Cus_Book_Click(object sender, EventArgs e)
        {
            Form form = this.GetParentForm();
            BookInfo bi = new BookInfo(this);
            form.Hide();
            bi.ShowDialog();

            form.Show();
        }

        //this is to find the parent form of this 
        public Form GetParentForm()
        {
            Control control = this;
            while (control != null && !(control is Form))
            {
                control = control.Parent;
            }
            return control as Form;
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_price_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void ptb_img_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }
    }
}

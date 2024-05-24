using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Uct_Emp_ImportAdd : UserControl
    {
        Emp_ImportAdd parent;
        public string ID
        {
            get { return lbl_id.Text; }
            set { lbl_id.Text = value; }
        }
        public string title
        {
            get { return lbl_title.Text; }
            set { lbl_title.Text = value;}
        }
        public string price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }
        }
        public string quantity
        {
            get { return lbl_quantity.Text; }
            set { lbl_quantity.Text = value;}
        }
        public string sum
        {
            get { return lbl_sum.Text; }
            set { lbl_sum.Text = value;}    
        }
        public Uct_Emp_ImportAdd(Emp_ImportAdd form)
        {
            InitializeComponent();
            this.parent = form;

        }
        public void LoadData(string id, string title, string price, string quantity)
        {
            this.ID = id;
            this.title = title;
            this.price = string.Format("{0:#,###}", int.Parse(price));
            this.quantity = quantity;
            long s = long.Parse(quantity) * long.Parse(price);
            this.sum = string.Format("{0:#,###}", s);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //remove this from the panel UI
            var fpnl = this.Parent as FlowLayoutPanel;
            fpnl.Controls.Remove(this);

            //remove this to the saved string
            for (int i = 0; i <parent.book_count; i++)
            {
                string[] split_line = parent.book_info[i].Split('*');
                if (split_line[0]==this.ID)
                {
                    RemoveItem(i);
                }
            }

            //readd this to the combobox (by reload all the item)
            ComboBox cbb_id = FindControlByName(parent, "cbb_bookid") as ComboBox;
            ComboBox cbb_name = FindControlByName(parent, "cbb_bookname") as ComboBox;

            cbb_id.Items.Clear();
            cbb_name.Items.Clear();

            connection co = new connection();
            SqlConnection sqlCon = new SqlConnection(co.connect);
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOK";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int flag = 0;
                for (int i=0;i<parent.book_count;i++)
                {
                    string[] spl = parent.book_info[i].Split('*');
                    if (spl[0]== dr.GetInt32(0).ToString())
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag==0)
                {
                    cbb_id.Items.Add(dr.GetInt32(0));
                    cbb_name.Items.Add(dr.GetString(2));
                }
            }

            sqlCon.Close();
            //re-calculate the total amount
            parent.CalcualteTotal();
        }

        public void RemoveItem(int index)
        {
            for (int i=index;i<parent.book_count-1;i++)
            {
                parent.book_info[i] = parent.book_info[i+1];
            }
            parent.book_count--;
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
    }
}

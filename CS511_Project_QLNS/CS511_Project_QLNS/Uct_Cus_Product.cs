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
    public partial class Uct_Cus_Product : UserControl
    {
        public string id;
        public int maximum;
        public int price;
        Form1 parent_form;
        public Uct_Cus_Product(Form1 parent_form)
        {
            InitializeComponent();
            this.parent_form = parent_form;
        }

        public void LoadData(string id, Image img, string name, string price, string quantity, int maximum)
        {
            this.id = id;
            ptb_img.BackgroundImage = img;

            lbl_name.Text = name;
            lbl_quantity.Text = quantity;

            this.price = int.Parse(price);
            this.maximum = maximum;

            //formatted the string price to the more money look-alike way
            string formattedNumber = string.Format("{0:#,###}", int.Parse(price));
            lbl_price.Text = formattedNumber;

            //calculate the sum
            int sum = int.Parse(quantity) * int.Parse(price);

            //format the sum to the more money look-alike way
            lbl_sum.Text = string.Format("{0:#,###}", sum);

            //update the sum of the prices in parent_form
            for (int i=0;i<parent_form.cart_count;i++)
            {
                string[] split_line = parent_form.cart_info[i].Split('*');
                if (split_line[0]==id)
                {
                    parent_form.cart_price[i] = sum;
                    break;
                }
            }
        }

        private void ptb_minus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lbl_quantity.Text);
            //if the quantity if greater than 1
            if (quantity > 1)
            {
                lbl_quantity.Text = (quantity-1).ToString();

                //calculate the sum again
                int sum = int.Parse(lbl_quantity.Text) * price;
                lbl_sum.Text = string.Format("{0:#,###}", sum);

                //adjust the saved string in parent_form (cart_info and cart_price)(cart_info and cart_price)
                for (int i = 0; i < parent_form.cart_count; i++)
                {
                    string[] split_line = parent_form.cart_info[i].Split('*');
                    if (split_line[0] == id)
                    {
                        parent_form.cart_info[i] = split_line[0] + "*"+lbl_quantity.Text;
                        parent_form.cart_price[i] = sum;
                        break;
                    }
                }

                //calculate the sum_price again in the Uct_Customer_Cart
                int sum_price = 0;
                for (int i = 0; i < parent_form.cart_count; i++)
                {
                    sum_price = parent_form.cart_price[i] + sum_price;
                }
                var parent = ((PictureBox)sender).Parent.Parent.Parent.Parent.Parent;
                Uct_Customer_Cart uct_parent = (Uct_Customer_Cart)parent;
                uct_parent.sumprice = string.Format("{0:#,###}", sum_price);

            }
        }

        private void ptb_plus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lbl_quantity.Text);
            //if the quantity is smaller than the maximum
            if (quantity < maximum)
            {
                lbl_quantity.Text = (quantity+1).ToString();

                //calculate the sum again
                int sum = int.Parse(lbl_quantity.Text) * price;
                lbl_sum.Text = string.Format("{0:#,###}", sum);

                //adjust the saved string in parent_form (cart_info and cart_price)
                for (int i = 0; i < parent_form.cart_count; i++)
                {
                    string[] split_line = parent_form.cart_info[i].Split('*');
                    if (split_line[0] == id)
                    {
                        parent_form.cart_info[i] = split_line[0] +"*"+ lbl_quantity.Text;
                        parent_form.cart_price[i] = sum; //ive just added this
                        break;
                    }
                }

                //calculate the sum_price again in the Uct_Customer_Cart
                int sum_price = 0;
                for (int i = 0; i < parent_form.cart_count; i++)
                {
                    sum_price = parent_form.cart_price[i] + sum_price;
                }
                var parent = ((PictureBox)sender).Parent.Parent.Parent.Parent.Parent;
                Uct_Customer_Cart uct_parent = (Uct_Customer_Cart)parent;
                uct_parent.sumprice  = string.Format("{0:#,###}", sum_price);
            }
        }

        private void ptb_delete_Click(object sender, EventArgs e)
        {
            //remove the uct on the fpnl

                //this is the fpnl
            var parent = ((PictureBox)sender).Parent.Parent.Parent;
                //this is the Uct_Cus_Product
            var parent_direct = ((PictureBox)sender).Parent.Parent;
            if (parent != null && parent is FlowLayoutPanel && parent_direct is Uct_Cus_Product)
            {
                parent.Controls.Remove(parent_direct);
            }

            //adjust the saved string in parent_form (cart_info and cart_price)
            for (int i = 0; i < parent_form.cart_count; i++)
            {
                string[] split_line = parent_form.cart_info[i].Split('*');
                if (split_line[0] == id)
                {
                    DeleteItemInString(i);
                }
            }

            //calculate the sum_price again in the Uct_Customer_Cart
            int sum_price = 0;
            for (int i = 0; i < parent_form.cart_count; i++)
            {
                sum_price = parent_form.cart_price[i] + sum_price;
            }
            var parent1 = parent.Parent;
            Uct_Customer_Cart uct_parent = (Uct_Customer_Cart)parent1;
            if (sum_price == 0)
                uct_parent.sumprice = "0";
            else
                uct_parent.sumprice = string.Format("{0:#,###}", sum_price);
        }
        private void DeleteItemInString(int index)
        {
            for (int i=index; i<parent_form.cart_count-1;i++)
            {
                parent_form.cart_info[i] = parent_form.cart_info[i+1];
                parent_form.cart_price[i] = parent_form.cart_price[i + 1];
            }
            parent_form.cart_count--;
        }
    }
}

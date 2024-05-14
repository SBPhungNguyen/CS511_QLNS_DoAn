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
        public int maximum;
        public int price;
        public Uct_Cus_Product()
        {
            InitializeComponent();
        }

        public void LoadData(Image img, string name, string price, string quantity, int maximum)
        {
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
        }

        private void ptb_minus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lbl_quantity.Text);
            if (quantity > 1)
            {
                lbl_quantity.Text = (quantity-1).ToString();
                lbl_sum.Text = string.Format("{0:#,###}", int.Parse(lbl_quantity.Text) * price);
            }
        }

        private void ptb_plus_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lbl_quantity.Text);
            if (quantity < maximum)
            {
                lbl_quantity.Text = (quantity+1).ToString();
                lbl_sum.Text = string.Format("{0:#,###}", int.Parse(lbl_quantity.Text) * price);

            }
        }
    }
}

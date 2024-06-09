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
    public partial class Uct_Cus_BookInfo_Detail : UserControl
    {
        public Uct_Cus_BookInfo_Detail()
        {
            InitializeComponent();
        }
        public void LoadData(int id, string title, string author, string genre, decimal price, string quantity, string des)
        {
            lbl_id.Text = id.ToString();
            lbl_title.Text = title;
            lbl_author.Text = author;
            string k = genre;
            switch (k)
            {
                case "1": lbl_genre.Text = "Classics"; break;
                case "2": lbl_genre.Text = "Fantasy"; break;
                case "3": lbl_genre.Text = "Self Help"; break;
                case "4": lbl_genre.Text = "Non-fiction"; break;
                case "5": lbl_genre.Text = "Mystery"; break;
                case "6": lbl_genre.Text = "History"; break;
            }
            string str = price.ToString("0.##");
            string formattedNumber = string.Format("{0:#,###}", int.Parse(str));

            lbl_price.Text = formattedNumber;

            lbl_quantity.Text = quantity;
            lbl_description.Text = des;
        }
    }
}

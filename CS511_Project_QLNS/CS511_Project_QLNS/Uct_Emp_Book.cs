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
    public partial class Uct_Emp_Book : UserControl
    {
        public int id;
        public string title
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value;}
        }
        public string author
        {
            get { return lbl_author.Text; }
            set { lbl_author.Text = value; }
        }
        public Image img
        {
            get
            {
                return ptb_img.BackgroundImage;
            }
            set
            {
                ptb_img.BackgroundImage = value;
            }
        }
        public Uct_Emp_Book()
        {
            InitializeComponent();
        }
        public void LoadData(int id, Image img, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.img = img;
        }
    }
}

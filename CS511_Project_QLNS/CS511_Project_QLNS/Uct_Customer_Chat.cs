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
    public partial class Uct_Customer_Chat : UserControl
    {
        public Uct_Customer_Chat()
        {
            InitializeComponent();
            fpnl_chat.AutoScroll = true;
            fpnl_chat.WrapContents = true;
        }
    }
}

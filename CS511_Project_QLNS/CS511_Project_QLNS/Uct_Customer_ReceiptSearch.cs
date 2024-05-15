using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace CS511_Project_QLNS
{
    public partial class Uct_Customer_ReceiptSearch : UserControl
    {
        public SqlConnection sqlCon;
        connection co = new connection();
        public SqlCommand cmd;
        string connect;
        public Uct_Customer_ReceiptSearch()
        {
            InitializeComponent();
            fpnl_receipt.WrapContents = true;
            fpnl_receipt.AutoScroll = true;

            connect = co.connect;
            sqlCon = new SqlConnection(connect);
        }

        private void btn_choosepic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture (.png) |*.png";
            ofd.Multiselect = false;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptb_img.BackgroundImage = Image.FromFile(ofd.FileName);
                Bitmap imgQRCode = (Bitmap)ptb_img.BackgroundImage;
                if (imgQRCode != null)
                {
                    try
                    {
                        ZXing.BarcodeReader rd = new ZXing.BarcodeReader();
                        Result result1 = rd.Decode(imgQRCode);
                        string decoded = result1.ToString().Trim();

                        if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                        cmd = new SqlCommand();
                        cmd.Connection = sqlCon;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COUNT(*) FROM TBL_CUS_RECEIPT WHERE ID_REC = " + decoded;
                        int count = (int)(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Sorry, there is no receipt with this code, please try another one", "Opps");
                            return;
                        }

                        //handle the actual qr code

                        //imgQRCode.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " ");
                    }
                }
            }
        }
    }
}

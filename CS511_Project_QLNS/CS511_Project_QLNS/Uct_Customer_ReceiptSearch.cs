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
                ClearFlowPanel();

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

                        //this is to load the customer receipt
                        cmd = new SqlCommand();
                        cmd.Connection = sqlCon;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM TBL_CUS_RECEIPT WHERE ID_REC = " + decoded;
                        SqlDataReader dr = cmd.ExecuteReader(); 
                        if (dr.Read())
                        {
                            lbl_code.Text = dr.GetInt32(0).ToString();
                            string[] sp_l = dr.GetDateTime(1).ToString().Split(' ');
                            lbl_date.Text = sp_l[0];
                            lbl_name.Text = dr.GetString(2).ToString();
                            lbl_sumprice.Text = string.Format("{0:#,###}", int.Parse(dr.GetDecimal(3).ToString("0.##")));

                        }
                        sqlCon.Close();

                        //this is to load the customer receipt details
                        if (sqlCon.State != ConnectionState.Open) { sqlCon.Open(); }
                        cmd = new SqlCommand();
                        cmd.Connection = sqlCon;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM TBL_REC_DETAIL WHERE ID_REC = " + decoded;
                        SqlDataReader dr1 = cmd.ExecuteReader();
                        while (dr1.Read())
                        {
                            Uct_Cus_Receipt uct = new Uct_Cus_Receipt();
                            string price = string.Format("{0:#,###}", int.Parse(dr1.GetDecimal(3).ToString("0.##")));
                            string sum = string.Format("{0:#,###}", int.Parse(dr1.GetDecimal(5).ToString("0.##")));
                            uct.LoadData(dr1.GetString(2), price,dr1.GetInt32(4).ToString(), sum);
                            fpnl_receipt.Controls.Add(uct);
                        }

                        sqlCon.Close();
                        //imgQRCode.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Sorry there is a problem, please try again", "Opps");
                    }
                }
            }
        }

        //Clear the flow panel before loading new ele
        private void ClearFlowPanel()
        {
            fpnl_receipt.SuspendLayout();

            if (fpnl_receipt.Controls.Count > 0)
            {
                for (int i = (fpnl_receipt.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = fpnl_receipt.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            fpnl_receipt.ResumeLayout();
        }
    }
}

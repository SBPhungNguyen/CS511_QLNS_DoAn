using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CS511_Project_QLNS
{
    public partial class Emp_Adv_Control : Form
    {
        private int lineThickness = 1; // Adjust for desired line thickness
        private Color lineColor = Color.Black; // 
        string type;
        SqlConnection sqlCon;
        SqlCommand cmd;
        connection co = new connection();
        FileInfo fileinfo;
        string new_pic_path;
        public Emp_Adv_Control(string type)
        {
            InitializeComponent();
            this.type = type;   
            sqlCon = new SqlConnection(co.connect);
            
            new_pic_path = "icon_banner.png";

            LoadData();
        }
        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM TBL_ADV WHERE AD_NAME = @type";
            cmd.Parameters.Add("@type", type);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Image img = System.Drawing.Image.FromFile(co.emp_dir + type + ".png");
                ptb_banner.BackgroundImage = img;
                txt_url.Texts = dr.GetString(1);
                if (dr.GetString(1)!="")
                {
                    new_pic_path = co.emp_dir + type + ".png";
                }
                else
                {
                    new_pic_path = "icon_banner.png";
                }
            }
            dr.Close();
            sqlCon.Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Draw the line using preferred placement and thickness
            e.Graphics.DrawRectangle(new Pen(lineColor, lineThickness), 0, 0, this.Width - 1, this.Height - 1);
        }

        public async Task<bool> IsUrlAccessibleAsync(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD"; // Use HEAD request to minimize data transfer
                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException ex)
            {
                // You might want to log ex.Message or handle it in some way
                return false;
            }
        }
        public bool IsValidUrl(string url)
        {
            Uri uriResult;
            return Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                   (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            ptb_banner.BackgroundImage.Dispose();
            this.Dispose();
            this.Close();
        }

        private async void customButton1_Click(object sender, EventArgs e)
        {
            if (txt_url.Texts == "")
            {
                MessageBox.Show("Please enter the URL link", "Opps");
                return;
            }
            if (!IsValidUrl(txt_url.Texts))
            {
                MessageBox.Show("The URL is invalid", "Opps");
                return;
            }
            if (new_pic_path != co.emp_dir + type + ".png")
            {
                fileinfo = new FileInfo(new_pic_path);
                ptb_banner.BackgroundImage.Dispose();
                fileinfo.CopyTo(co.emp_dir + type + ".png", true);
            }
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE TBL_ADV SET AD_LINK = @url WHERE AD_NAME = @type";
            cmd.Parameters.AddWithValue("url",txt_url.Texts);
            cmd.Parameters.AddWithValue("@type",type);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Update successfully", "Congrats");
            ptb_banner.BackgroundImage.Dispose();
            this.Dispose();
            this.Close();
        }

        private void ptb_banner_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture (.png) |*.png";
            ofd.Multiselect = false;
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                new_pic_path = ofd.FileName;
                ptb_banner.BackgroundImage.Dispose();
                ptb_banner.BackgroundImage = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Process.Start(txt_url.Texts);
        }
    }
}

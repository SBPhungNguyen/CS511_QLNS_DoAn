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
using static System.Windows.Forms.AxHost;

namespace CS511_Project_QLNS
{
    public partial class Uct_Emp_HomeInfo : UserControl
    {
        Color btn_chosen = Color.Orange;
        Color btn_normal = Color.FromArgb(24,138,93);

        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;

        int is_chosen;
        public Uct_Emp_HomeInfo()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);

            is_chosen = 0;
            SetStateLabel(true);
            SetStateTxt(false);

            LoadData();
        }
        private void SetStateLabel(bool state)
        {
            lbl_name.Visible = state;
            lbl_location.Visible = state;
            lbl_quote.Visible = state;
            lbl_mail.Visible = state;
            lbl_phone.Visible = state;
        }
        private void SetStateTxt(bool state)
        {
            txt_location.Visible=state;
            txt_quote.Visible=state;
            txt_mail.Visible=state;
            txt_name.Visible=state;
            txt_phone.Visible=state;
        }
        private void LoadDataLabel_FromTxt()
        {
            lbl_name.Text = txt_name.Texts;
            lbl_phone.Text = txt_phone.Texts;
            lbl_quote.Text = txt_quote.Texts;
            lbl_mail.Text = txt_mail.Texts;
            lbl_location.Text = txt_location.Texts;
        }
        private void LoadDataTxt_FromLabel()
        {
            txt_location.Texts = lbl_location.Text;
            txt_quote.Texts = lbl_quote.Text;
            txt_mail.Texts = lbl_mail.Text;
            txt_name.Texts = lbl_name.Text;
            txt_phone.Texts = lbl_phone.Text;   
        }
        private void customButton1_Click(object sender, EventArgs e)
        {
            is_chosen++;
            if (is_chosen%2==1) //when it's chosen
            {
                btn_edit.BackColor = btn_chosen;
                btn_edit.Text = "Save";
                SetStateLabel(false);
                SetStateTxt(true);
                LoadDataTxt_FromLabel();
            }
            else
            {
                btn_edit.BackColor = btn_normal;
                btn_edit.Text = "Edit";
                SetStateLabel(true);
                SetStateTxt(false);
                LoadDataLabel_FromTxt();
                SaveData();
            }
        }

        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_BOOKSTORE_INFO";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_name.Text = dr.GetString(1);
                lbl_quote.Text = dr.GetString(2);
                lbl_location.Text = dr.GetString(3);
                lbl_mail.Text = dr.GetString(4);
                lbl_phone.Text = dr.GetString(5);
            }
            dr.Close();
            sqlCon.Close();
        }

        public void SaveData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
            cmd.CommandText = "UPDATE TBL_BOOKSTORE_INFO SET S_NAME = @name, S_QUOTE = @quote, S_LOCATION = @location, S_MAIL = @mail, S_PHONE = @phone WHERE S_ID = 1";
            cmd.Parameters.AddWithValue("@name",txt_name.Texts);
            cmd.Parameters.AddWithValue("@quote",txt_quote.Texts);
            cmd.Parameters.AddWithValue("@location",txt_location.Texts);
            cmd.Parameters.AddWithValue("@mail", txt_mail.Texts);
            cmd.Parameters.AddWithValue("@phone",txt_phone.Texts);
            cmd.ExecuteNonQuery();
            sqlCon.Close();

        }
    }
}

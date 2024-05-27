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

namespace CS511_Project_QLNS
{
    public partial class Uct_Emp_Import : UserControl
    {
        connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Emp_Import()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(co.connect);
        }
        public void LoadData(int id, string name, string date, string money)
        {
            lbl_id.Text = id.ToString();
            lbl_name.Text = name;
            lbl_date.Text = date;    
            lbl_sum.Text = money;
        }

        private void Uct_Emp_Import_Click(object sender, EventArgs e)
        {
            Emp_ImportInfo emp_ImportInfo = new Emp_ImportInfo(lbl_id.Text);
            emp_ImportInfo.ShowDialog();
        }

        private void lbl_sum_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void customPanel1_Click(object sender, EventArgs e)
        {
            this.OnClick(null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to remove this permanently\nThis receipt will be rollback if possible", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //check if this can be roll-back (the amount of all the books is no greater than its current quantity
                if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TBL_BOOK.ID, TBL_IMP_DETAIL.QUANTITY AS Q1, TBL_BOOK.QUANTITY AS Q2 FROM TBL_IMP_DETAIL, TBL_BOOK WHERE ID_BOOK = ID AND ID_IMP = " + lbl_id.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetInt32(1) > dr.GetInt32(2))
                    {
                        MessageBox.Show("Cannot rollback this receipt because the amount of book with ID " + dr.GetInt32(0) + " is less than the quantity of the receipt", "Error");
                        dr.Close();
                        return;
                    }
                }
                dr.Close();

                //in case this can be rollback

                //decrease the amount of book 
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE TBL_BOOK SET QUANTITY = TBL_BOOK.QUANTITY - TBL_IMP_DETAIL.QUANTITY FROM TBL_BOOK, TBL_IMP_DETAIL WHERE TBL_BOOK.ID = TBL_IMP_DETAIL.ID_BOOK AND TBL_IMP_DETAIL.ID_IMP = "+lbl_id.Text;
                cmd.ExecuteNonQuery();

                //delete it on the UI
                FlowLayoutPanel fpnl = this.Parent as FlowLayoutPanel;
                fpnl.Controls.Remove(this);

                //delete the Receipt Detail (TBL_IMP_DETAIL)
                cmd = new SqlCommand(); 
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM TBL_IMP_DETAIL WHERE ID_IMP = "+lbl_id.Text;
                cmd.ExecuteNonQuery();

                //delete in the TBL_EMP_IMPORT
                cmd = new SqlCommand();
                cmd.Connection = sqlCon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM TBL_EMP_IMPORT WHERE ID = " + lbl_id.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}

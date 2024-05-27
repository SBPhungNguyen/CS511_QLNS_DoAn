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
    public partial class Uct_Employee_Import : UserControl
    {
        public connection co = new connection();
        SqlConnection sqlCon;
        SqlCommand cmd;
        public Uct_Employee_Import()
        {
            InitializeComponent();
            fpnl_import.WrapContents = true;
            fpnl_import.AutoScroll = true;

            sqlCon = new SqlConnection(co.connect);
            LoadData();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Form2 parent_form;
            var pa = this.ParentForm;
            parent_form = pa as Form2;

            Emp_ImportAdd emp_ImportAdd = new Emp_ImportAdd(parent_form);
            parent_form.Hide();

            emp_ImportAdd.ShowDialog();

            ClearFlowPanel();
            LoadData();
            parent_form.Show();
        }

        public void LoadData()
        {
            if (sqlCon.State == ConnectionState.Closed) { sqlCon.Open(); }
            cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TBL_EMP_IMPORT";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Uct_Emp_Import imp = new Uct_Emp_Import();
                string[] split_line = dr.GetDateTime(1).ToString().Split(' ');
                imp.LoadData(dr.GetInt32(0), dr.GetString(3), split_line[0], string.Format("{0:#,###}", int.Parse(dr.GetDecimal(4).ToString("0.##"))));
                fpnl_import.Controls.Add( imp );
            }
            dr.Close();
            sqlCon.Close();
        }

        //Clear the flow panel before loading new ele
        public void ClearFlowPanel()
        {
            fpnl_import.SuspendLayout();

            if (fpnl_import.Controls.Count > 0)
            {
                for (int i = (fpnl_import.Controls.Count - 1); i >= 0; i--)
                {
                    Control c = fpnl_import.Controls[i];
                    c.Dispose();
                }
                GC.Collect();
            }
            fpnl_import.ResumeLayout();
        }
    }
}

namespace CS511_Project_QLNS
{
    partial class Uct_Employee_Report
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cat1 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_all = new CS511_Project_QLNS.View.CustomButton();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cat1
            // 
            this.btn_cat1.BackColor = System.Drawing.Color.Green;
            this.btn_cat1.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat1.BorderRadius = 0;
            this.btn_cat1.BorderSize = 0;
            this.btn_cat1.FlatAppearance.BorderSize = 0;
            this.btn_cat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat1.ForeColor = System.Drawing.Color.White;
            this.btn_cat1.Location = new System.Drawing.Point(490, 58);
            this.btn_cat1.Name = "btn_cat1";
            this.btn_cat1.Size = new System.Drawing.Size(490, 40);
            this.btn_cat1.TabIndex = 44;
            this.btn_cat1.Text = "customButton2";
            this.btn_cat1.TextColor = System.Drawing.Color.White;
            this.btn_cat1.UseVisualStyleBackColor = false;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Green;
            this.btn_all.BackgroundColor = System.Drawing.Color.Green;
            this.btn_all.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_all.BorderRadius = 0;
            this.btn_all.BorderSize = 0;
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(0, 58);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(490, 40);
            this.btn_all.TabIndex = 43;
            this.btn_all.Text = "customButton1";
            this.btn_all.TextColor = System.Drawing.Color.White;
            this.btn_all.UseVisualStyleBackColor = false;
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(1, 119);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(220, 26);
            this.cbb_month.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Revenue by all months";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Top 5 best-sellers";
            // 
            // Uct_Employee_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.btn_cat1);
            this.Controls.Add(this.btn_all);
            this.Name = "Uct_Employee_Report";
            this.Size = new System.Drawing.Size(980, 675);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.CustomButton btn_cat1;
        private View.CustomButton btn_all;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

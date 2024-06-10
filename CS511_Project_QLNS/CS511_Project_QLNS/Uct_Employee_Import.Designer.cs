namespace CS511_Project_QLNS
{
    partial class Uct_Employee_Import
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
            this.fpnl_import = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel2 = new CS511_Project_QLNS.View.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customButton1 = new CS511_Project_QLNS.View.CustomButton();
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.txt_search = new CS511_Project_QLNS.Uct_textbox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnl_import
            // 
            this.fpnl_import.BackColor = System.Drawing.SystemColors.Window;
            this.fpnl_import.Location = new System.Drawing.Point(1, 195);
            this.fpnl_import.Name = "fpnl_import";
            this.fpnl_import.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fpnl_import.Size = new System.Drawing.Size(1736, 725);
            this.fpnl_import.TabIndex = 52;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(171)))), ((int)(((byte)(116)))));
            this.customPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(69)))));
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Controls.Add(this.label5);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Location = new System.Drawing.Point(1, 132);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Radius = 5;
            this.customPanel2.Size = new System.Drawing.Size(1690, 59);
            this.customPanel2.TabIndex = 51;
            this.customPanel2.Thickness = 2F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1306, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(953, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Green;
            this.customButton1.BackgroundColor = System.Drawing.Color.Green;
            this.customButton1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(970, 62);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(250, 55);
            this.customButton1.TabIndex = 50;
            this.customButton1.Text = "Add";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(69)))));
            this.customPanel1.Controls.Add(this.cbb_type);
            this.customPanel1.Controls.Add(this.txt_search);
            this.customPanel1.Controls.Add(this.ptb_Search);
            this.customPanel1.Location = new System.Drawing.Point(1, 62);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 5;
            this.customPanel1.Size = new System.Drawing.Size(606, 53);
            this.customPanel1.TabIndex = 49;
            this.customPanel1.Thickness = 2F;
            // 
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Items.AddRange(new object[] {
            "All",
            "ID",
            "Name",
            "Date"});
            this.cbb_type.Location = new System.Drawing.Point(14, 11);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(121, 32);
            this.cbb_type.TabIndex = 8;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_search.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_search.BorderSize = 2;
            this.txt_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(150, 9);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(7);
            this.txt_search.PasswordChar = false;
            this.txt_search.Size = new System.Drawing.Size(397, 38);
            this.txt_search.TabIndex = 7;
            this.txt_search.Texts = "";
            this.txt_search.UnderlineStyle = true;
            // 
            // ptb_Search
            // 
            this.ptb_Search.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_search;
            this.ptb_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Search.Location = new System.Drawing.Point(559, 6);
            this.ptb_Search.Name = "ptb_Search";
            this.ptb_Search.Size = new System.Drawing.Size(40, 40);
            this.ptb_Search.TabIndex = 5;
            this.ptb_Search.TabStop = false;
            this.ptb_Search.Click += new System.EventHandler(this.ptb_Search_Click);
            // 
            // Uct_Employee_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fpnl_import);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customPanel1);
            this.Name = "Uct_Employee_Import";
            this.Size = new System.Drawing.Size(1740, 930);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomButton customButton1;
        private View.CustomPanel customPanel1;
        private Uct_textbox txt_search;
        private System.Windows.Forms.PictureBox ptb_Search;
        private View.CustomPanel customPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnl_import;
        private System.Windows.Forms.ComboBox cbb_type;
    }
}

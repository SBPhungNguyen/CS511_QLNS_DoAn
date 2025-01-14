﻿namespace CS511_Project_QLNS
{
    partial class Uct_Emp_BookSearch
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
            this.fpnl_books = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new CS511_Project_QLNS.View.CustomButton();
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.txt_search = new CS511_Project_QLNS.Uct_textbox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            this.btn_cat6 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_cat5 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_cat4 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_cat3 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_cat2 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_cat1 = new CS511_Project_QLNS.View.CustomButton();
            this.btn_all = new CS511_Project_QLNS.View.CustomButton();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnl_books
            // 
            this.fpnl_books.BackColor = System.Drawing.Color.White;
            this.fpnl_books.Location = new System.Drawing.Point(0, 150);
            this.fpnl_books.Name = "fpnl_books";
            this.fpnl_books.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fpnl_books.Size = new System.Drawing.Size(1697, 747);
            this.fpnl_books.TabIndex = 50;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Green;
            this.btn_add.BackgroundColor = System.Drawing.Color.Green;
            this.btn_add.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.BorderRadius = 20;
            this.btn_add.BorderSize = 0;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(1200, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(240, 55);
            this.btn_add.TabIndex = 58;
            this.btn_add.Text = "Add";
            this.btn_add.TextColor = System.Drawing.Color.White;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(69)))));
            this.customPanel1.Controls.Add(this.txt_search);
            this.customPanel1.Controls.Add(this.cbb_type);
            this.customPanel1.Controls.Add(this.ptb_Search);
            this.customPanel1.Location = new System.Drawing.Point(2, 1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 5;
            this.customPanel1.Size = new System.Drawing.Size(606, 53);
            this.customPanel1.TabIndex = 49;
            this.customPanel1.Thickness = 2F;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_search.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_search.BorderSize = 2;
            this.txt_search.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_search.ForeColor = System.Drawing.Color.Black;
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
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Items.AddRange(new object[] {
            "All",
            "Title",
            "Author"});
            this.cbb_type.Location = new System.Drawing.Point(14, 11);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(121, 32);
            this.cbb_type.TabIndex = 6;
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
            // btn_cat6
            // 
            this.btn_cat6.BackColor = System.Drawing.Color.Green;
            this.btn_cat6.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat6.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat6.BorderRadius = 0;
            this.btn_cat6.BorderSize = 0;
            this.btn_cat6.FlatAppearance.BorderSize = 0;
            this.btn_cat6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat6.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_cat6.ForeColor = System.Drawing.Color.White;
            this.btn_cat6.Location = new System.Drawing.Point(1440, 84);
            this.btn_cat6.Name = "btn_cat6";
            this.btn_cat6.Size = new System.Drawing.Size(240, 60);
            this.btn_cat6.TabIndex = 57;
            this.btn_cat6.Text = "History";
            this.btn_cat6.TextColor = System.Drawing.Color.White;
            this.btn_cat6.UseVisualStyleBackColor = false;
            this.btn_cat6.Click += new System.EventHandler(this.btn_cat6_Click);
            // 
            // btn_cat5
            // 
            this.btn_cat5.BackColor = System.Drawing.Color.Green;
            this.btn_cat5.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat5.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat5.BorderRadius = 0;
            this.btn_cat5.BorderSize = 0;
            this.btn_cat5.FlatAppearance.BorderSize = 0;
            this.btn_cat5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat5.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_cat5.ForeColor = System.Drawing.Color.White;
            this.btn_cat5.Location = new System.Drawing.Point(1200, 84);
            this.btn_cat5.Name = "btn_cat5";
            this.btn_cat5.Size = new System.Drawing.Size(240, 60);
            this.btn_cat5.TabIndex = 56;
            this.btn_cat5.Text = "Mystery";
            this.btn_cat5.TextColor = System.Drawing.Color.White;
            this.btn_cat5.UseVisualStyleBackColor = false;
            this.btn_cat5.Click += new System.EventHandler(this.btn_cat5_Click);
            // 
            // btn_cat4
            // 
            this.btn_cat4.BackColor = System.Drawing.Color.Green;
            this.btn_cat4.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat4.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat4.BorderRadius = 0;
            this.btn_cat4.BorderSize = 0;
            this.btn_cat4.FlatAppearance.BorderSize = 0;
            this.btn_cat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat4.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_cat4.ForeColor = System.Drawing.Color.White;
            this.btn_cat4.Location = new System.Drawing.Point(960, 84);
            this.btn_cat4.Name = "btn_cat4";
            this.btn_cat4.Size = new System.Drawing.Size(240, 60);
            this.btn_cat4.TabIndex = 55;
            this.btn_cat4.Text = "Non-Fiction";
            this.btn_cat4.TextColor = System.Drawing.Color.White;
            this.btn_cat4.UseVisualStyleBackColor = false;
            this.btn_cat4.Click += new System.EventHandler(this.btn_cat4_Click);
            // 
            // btn_cat3
            // 
            this.btn_cat3.BackColor = System.Drawing.Color.Green;
            this.btn_cat3.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat3.BorderRadius = 0;
            this.btn_cat3.BorderSize = 0;
            this.btn_cat3.FlatAppearance.BorderSize = 0;
            this.btn_cat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat3.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_cat3.ForeColor = System.Drawing.Color.White;
            this.btn_cat3.Location = new System.Drawing.Point(720, 84);
            this.btn_cat3.Name = "btn_cat3";
            this.btn_cat3.Size = new System.Drawing.Size(240, 60);
            this.btn_cat3.TabIndex = 54;
            this.btn_cat3.Text = "Self Help";
            this.btn_cat3.TextColor = System.Drawing.Color.White;
            this.btn_cat3.UseVisualStyleBackColor = false;
            this.btn_cat3.Click += new System.EventHandler(this.btn_cat3_Click);
            // 
            // btn_cat2
            // 
            this.btn_cat2.BackColor = System.Drawing.Color.Green;
            this.btn_cat2.BackgroundColor = System.Drawing.Color.Green;
            this.btn_cat2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cat2.BorderRadius = 0;
            this.btn_cat2.BorderSize = 0;
            this.btn_cat2.FlatAppearance.BorderSize = 0;
            this.btn_cat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cat2.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_cat2.ForeColor = System.Drawing.Color.White;
            this.btn_cat2.Location = new System.Drawing.Point(480, 84);
            this.btn_cat2.Name = "btn_cat2";
            this.btn_cat2.Size = new System.Drawing.Size(240, 60);
            this.btn_cat2.TabIndex = 53;
            this.btn_cat2.Text = "Fantasy";
            this.btn_cat2.TextColor = System.Drawing.Color.White;
            this.btn_cat2.UseVisualStyleBackColor = false;
            this.btn_cat2.Click += new System.EventHandler(this.btn_cat2_Click);
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
            this.btn_cat1.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_cat1.ForeColor = System.Drawing.Color.White;
            this.btn_cat1.Location = new System.Drawing.Point(240, 84);
            this.btn_cat1.Name = "btn_cat1";
            this.btn_cat1.Size = new System.Drawing.Size(240, 60);
            this.btn_cat1.TabIndex = 52;
            this.btn_cat1.Text = "Classics";
            this.btn_cat1.TextColor = System.Drawing.Color.White;
            this.btn_cat1.UseVisualStyleBackColor = false;
            this.btn_cat1.Click += new System.EventHandler(this.btn_cat1_Click);
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
            this.btn_all.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(0, 84);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(240, 60);
            this.btn_all.TabIndex = 51;
            this.btn_all.Text = "All";
            this.btn_all.TextColor = System.Drawing.Color.White;
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Uct_Emp_BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.fpnl_books);
            this.Controls.Add(this.btn_cat6);
            this.Controls.Add(this.btn_cat5);
            this.Controls.Add(this.btn_cat4);
            this.Controls.Add(this.btn_cat3);
            this.Controls.Add(this.btn_cat2);
            this.Controls.Add(this.btn_cat1);
            this.Controls.Add(this.btn_all);
            this.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.Name = "Uct_Emp_BookSearch";
            this.Size = new System.Drawing.Size(1680, 900);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomButton btn_add;
        private View.CustomPanel customPanel1;
        private Uct_textbox txt_search;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.PictureBox ptb_Search;
        private System.Windows.Forms.FlowLayoutPanel fpnl_books;
        private View.CustomButton btn_cat6;
        private View.CustomButton btn_cat5;
        private View.CustomButton btn_cat4;
        private View.CustomButton btn_cat3;
        private View.CustomButton btn_cat2;
        private View.CustomButton btn_cat1;
        private View.CustomButton btn_all;
    }
}

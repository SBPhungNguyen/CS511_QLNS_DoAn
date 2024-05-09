﻿namespace CS511_Project_QLNS
{
    partial class Uct_Employee_Cashier
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
            this.customButton1 = new CS511_Project_QLNS.View.CustomButton();
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.txt_search = new CS511_Project_QLNS.Uct_textbox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.ptb_Search = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).BeginInit();
            this.SuspendLayout();
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
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(692, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(150, 40);
            this.customButton1.TabIndex = 50;
            this.customButton1.Text = "Add";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(69)))));
            this.customPanel1.Controls.Add(this.txt_search);
            this.customPanel1.Controls.Add(this.cbb_type);
            this.customPanel1.Controls.Add(this.ptb_Search);
            this.customPanel1.Location = new System.Drawing.Point(1, 1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 5;
            this.customPanel1.Size = new System.Drawing.Size(425, 45);
            this.customPanel1.TabIndex = 49;
            this.customPanel1.Thickness = 2F;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_search.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_search.BorderSize = 2;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(141, 4);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Multiline = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(7);
            this.txt_search.PasswordChar = false;
            this.txt_search.Size = new System.Drawing.Size(229, 35);
            this.txt_search.TabIndex = 7;
            this.txt_search.Texts = "";
            this.txt_search.UnderlineStyle = true;
            // 
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Location = new System.Drawing.Point(12, 9);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(121, 26);
            this.cbb_type.TabIndex = 6;
            // 
            // ptb_Search
            // 
            this.ptb_Search.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_search;
            this.ptb_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_Search.Location = new System.Drawing.Point(379, 5);
            this.ptb_Search.Name = "ptb_Search";
            this.ptb_Search.Size = new System.Drawing.Size(35, 35);
            this.ptb_Search.TabIndex = 5;
            this.ptb_Search.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(976, 607);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // Uct_Employee_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customPanel1);
            this.Name = "Uct_Employee_Cashier";
            this.Size = new System.Drawing.Size(980, 675);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomButton customButton1;
        private View.CustomPanel customPanel1;
        private Uct_textbox txt_search;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.PictureBox ptb_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
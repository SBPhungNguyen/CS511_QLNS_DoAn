namespace CS511_Project_QLNS
{
    partial class Emp_BookEdit
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_BookEdit));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.Label();
            this.btn_cancel = new CS511_Project_QLNS.View.CustomButton();
            this.btn_update = new CS511_Project_QLNS.View.CustomButton();
            this.txt_title = new CS511_Project_QLNS.Uct_textbox();
            this.txt_author = new CS511_Project_QLNS.Uct_textbox();
            this.txt_des = new CS511_Project_QLNS.Uct_textbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_im_price = new CS511_Project_QLNS.Uct_textbox();
            this.txt_sell_price = new CS511_Project_QLNS.Uct_textbox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(909, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 33);
            this.label6.TabIndex = 54;
            this.label6.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(907, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 33);
            this.label4.TabIndex = 52;
            this.label4.Text = "Selling Price:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lbl_id.Location = new System.Drawing.Point(1162, 225);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(88, 32);
            this.lbl_id.TabIndex = 55;
            this.lbl_id.Text = "Code:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1901, 45);
            this.panel1.TabIndex = 51;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1861, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(35, 35);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(909, 743);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 33);
            this.label9.TabIndex = 47;
            this.label9.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(907, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 41;
            this.label3.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(907, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Title:";
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_picture;
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(382, 226);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(310, 400);
            this.ptb_img.TabIndex = 39;
            this.ptb_img.TabStop = false;
            this.ptb_img.Click += new System.EventHandler(this.ptb_img_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(909, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 64;
            this.label2.Text = "Quantity:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.AutoSize = true;
            this.txt_quantity.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_quantity.Location = new System.Drawing.Point(1162, 662);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(88, 32);
            this.txt_quantity.TabIndex = 65;
            this.txt_quantity.Text = "Code:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancel.BackgroundColor = System.Drawing.Color.LightGray;
            this.btn_cancel.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cancel.BorderRadius = 20;
            this.btn_cancel.BorderSize = 1;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(1325, 909);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(353, 60);
            this.btn_cancel.TabIndex = 62;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextColor = System.Drawing.Color.Black;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.BackgroundColor = System.Drawing.Color.Green;
            this.btn_update.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_update.BorderRadius = 20;
            this.btn_update.BorderSize = 0;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(382, 909);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(353, 60);
            this.btn_update.TabIndex = 61;
            this.btn_update.Text = "Update";
            this.btn_update.TextColor = System.Drawing.Color.White;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_title
            // 
            this.txt_title.BackColor = System.Drawing.SystemColors.Window;
            this.txt_title.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_title.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_title.BorderSize = 2;
            this.txt_title.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_title.ForeColor = System.Drawing.Color.Black;
            this.txt_title.Location = new System.Drawing.Point(1168, 281);
            this.txt_title.Margin = new System.Windows.Forms.Padding(4);
            this.txt_title.Multiline = false;
            this.txt_title.Name = "txt_title";
            this.txt_title.Padding = new System.Windows.Forms.Padding(7);
            this.txt_title.PasswordChar = false;
            this.txt_title.Size = new System.Drawing.Size(510, 47);
            this.txt_title.TabIndex = 60;
            this.txt_title.Texts = "";
            this.txt_title.UnderlineStyle = true;
            // 
            // txt_author
            // 
            this.txt_author.BackColor = System.Drawing.SystemColors.Window;
            this.txt_author.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_author.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_author.BorderSize = 2;
            this.txt_author.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_author.ForeColor = System.Drawing.Color.Black;
            this.txt_author.Location = new System.Drawing.Point(1168, 350);
            this.txt_author.Margin = new System.Windows.Forms.Padding(4);
            this.txt_author.Multiline = false;
            this.txt_author.Name = "txt_author";
            this.txt_author.Padding = new System.Windows.Forms.Padding(7);
            this.txt_author.PasswordChar = false;
            this.txt_author.Size = new System.Drawing.Size(510, 47);
            this.txt_author.TabIndex = 57;
            this.txt_author.Texts = "";
            this.txt_author.UnderlineStyle = true;
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.SystemColors.Window;
            this.txt_des.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_des.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_des.BorderSize = 2;
            this.txt_des.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_des.ForeColor = System.Drawing.Color.Black;
            this.txt_des.Location = new System.Drawing.Point(1168, 729);
            this.txt_des.Margin = new System.Windows.Forms.Padding(4);
            this.txt_des.Multiline = false;
            this.txt_des.Name = "txt_des";
            this.txt_des.Padding = new System.Windows.Forms.Padding(7);
            this.txt_des.PasswordChar = false;
            this.txt_des.Size = new System.Drawing.Size(510, 47);
            this.txt_des.TabIndex = 56;
            this.txt_des.Texts = "";
            this.txt_des.UnderlineStyle = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(458, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(998, 52);
            this.label8.TabIndex = 85;
            this.label8.Text = "BOOK UPDATE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(907, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(909, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 33);
            this.label7.TabIndex = 45;
            this.label7.Text = "Import Price:";
            // 
            // txt_im_price
            // 
            this.txt_im_price.BackColor = System.Drawing.SystemColors.Window;
            this.txt_im_price.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_im_price.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_im_price.BorderSize = 2;
            this.txt_im_price.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_im_price.ForeColor = System.Drawing.Color.Black;
            this.txt_im_price.Location = new System.Drawing.Point(1168, 490);
            this.txt_im_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_im_price.Multiline = false;
            this.txt_im_price.Name = "txt_im_price";
            this.txt_im_price.Padding = new System.Windows.Forms.Padding(7);
            this.txt_im_price.PasswordChar = false;
            this.txt_im_price.Size = new System.Drawing.Size(510, 47);
            this.txt_im_price.TabIndex = 58;
            this.txt_im_price.Texts = "";
            this.txt_im_price.UnderlineStyle = true;
            // 
            // txt_sell_price
            // 
            this.txt_sell_price.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sell_price.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_sell_price.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_sell_price.BorderSize = 2;
            this.txt_sell_price.Font = new System.Drawing.Font("Arial", 16.2F);
            this.txt_sell_price.ForeColor = System.Drawing.Color.Black;
            this.txt_sell_price.Location = new System.Drawing.Point(1168, 570);
            this.txt_sell_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sell_price.Multiline = false;
            this.txt_sell_price.Name = "txt_sell_price";
            this.txt_sell_price.Padding = new System.Windows.Forms.Padding(7);
            this.txt_sell_price.PasswordChar = false;
            this.txt_sell_price.Size = new System.Drawing.Size(510, 47);
            this.txt_sell_price.TabIndex = 59;
            this.txt_sell_price.Texts = "";
            this.txt_sell_price.UnderlineStyle = true;
            // 
            // cbb_type
            // 
            this.cbb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_type.Font = new System.Drawing.Font("Arial", 16.2F);
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Items.AddRange(new object[] {
            "Classics",
            "Fantasy",
            "Self Help",
            "Non-Fiction",
            "Mystery",
            "History"});
            this.cbb_type.Location = new System.Drawing.Point(1168, 435);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(510, 40);
            this.cbb_type.TabIndex = 63;
            // 
            // Emp_BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1900, 1102);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_type);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_sell_price);
            this.Controls.Add(this.txt_im_price);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_img);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_BookEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emp_BookEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_img;
        private Uct_textbox txt_des;
        private Uct_textbox txt_author;
        private Uct_textbox txt_title;
        private View.CustomButton btn_update;
        private View.CustomButton btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Uct_textbox txt_im_price;
        private Uct_textbox txt_sell_price;
        private System.Windows.Forms.ComboBox cbb_type;
    }
}
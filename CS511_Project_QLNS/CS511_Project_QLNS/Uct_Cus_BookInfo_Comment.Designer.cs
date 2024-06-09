namespace CS511_Project_QLNS
{
    partial class Uct_Cus_BookInfo_Comment
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtb_cmttext = new System.Windows.Forms.RichTextBox();
            this.ptb_cmtpic = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ptb_star5 = new System.Windows.Forms.PictureBox();
            this.ptb_star4 = new System.Windows.Forms.PictureBox();
            this.ptb_star3 = new System.Windows.Forms.PictureBox();
            this.ptb_star2 = new System.Windows.Forms.PictureBox();
            this.ptb_star1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnl_cmt = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_postcomment = new CS511_Project_QLNS.View.CustomButton();
            this.txt_cmtname = new CS511_Project_QLNS.Uct_textbox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cmtpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Green;
            this.lbl_title.Location = new System.Drawing.Point(917, 40);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(245, 52);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "COMMENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(658, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 34);
            this.label10.TabIndex = 54;
            this.label10.Text = "Other Comments";
            // 
            // rtb_cmttext
            // 
            this.rtb_cmttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_cmttext.Location = new System.Drawing.Point(664, 231);
            this.rtb_cmttext.Name = "rtb_cmttext";
            this.rtb_cmttext.Size = new System.Drawing.Size(825, 75);
            this.rtb_cmttext.TabIndex = 51;
            this.rtb_cmttext.Text = "";
            // 
            // ptb_cmtpic
            // 
            this.ptb_cmtpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_cmtpic.Location = new System.Drawing.Point(539, 231);
            this.ptb_cmtpic.Name = "ptb_cmtpic";
            this.ptb_cmtpic.Size = new System.Drawing.Size(75, 75);
            this.ptb_cmtpic.TabIndex = 50;
            this.ptb_cmtpic.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 27);
            this.label8.TabIndex = 48;
            this.label8.Text = "Name:";
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_female.Location = new System.Drawing.Point(1381, 177);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(108, 30);
            this.rad_female.TabIndex = 47;
            this.rad_female.TabStop = true;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            this.rad_female.CheckedChanged += new System.EventHandler(this.rad_female_CheckedChanged);
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_male.Location = new System.Drawing.Point(1280, 177);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(82, 30);
            this.rad_male.TabIndex = 46;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            this.rad_male.CheckedChanged += new System.EventHandler(this.rad_male_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1150, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "Gender:";
            // 
            // ptb_star5
            // 
            this.ptb_star5.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_star_black;
            this.ptb_star5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_star5.Location = new System.Drawing.Point(861, 129);
            this.ptb_star5.Name = "ptb_star5";
            this.ptb_star5.Size = new System.Drawing.Size(33, 33);
            this.ptb_star5.TabIndex = 44;
            this.ptb_star5.TabStop = false;
            this.ptb_star5.Click += new System.EventHandler(this.ptb_star5_Click);
            this.ptb_star5.MouseEnter += new System.EventHandler(this.ptb_star5_MouseEnter);
            this.ptb_star5.MouseLeave += new System.EventHandler(this.ptb_star5_MouseLeave);
            // 
            // ptb_star4
            // 
            this.ptb_star4.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_star_black;
            this.ptb_star4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_star4.Location = new System.Drawing.Point(812, 129);
            this.ptb_star4.Name = "ptb_star4";
            this.ptb_star4.Size = new System.Drawing.Size(33, 33);
            this.ptb_star4.TabIndex = 43;
            this.ptb_star4.TabStop = false;
            this.ptb_star4.Click += new System.EventHandler(this.ptb_star4_Click);
            this.ptb_star4.MouseEnter += new System.EventHandler(this.ptb_star4_MouseEnter);
            this.ptb_star4.MouseLeave += new System.EventHandler(this.ptb_star4_MouseLeave);
            // 
            // ptb_star3
            // 
            this.ptb_star3.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_star_black;
            this.ptb_star3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_star3.Location = new System.Drawing.Point(763, 129);
            this.ptb_star3.Name = "ptb_star3";
            this.ptb_star3.Size = new System.Drawing.Size(33, 33);
            this.ptb_star3.TabIndex = 42;
            this.ptb_star3.TabStop = false;
            this.ptb_star3.Click += new System.EventHandler(this.ptb_star3_Click);
            this.ptb_star3.MouseEnter += new System.EventHandler(this.ptb_star3_MouseEnter);
            this.ptb_star3.MouseLeave += new System.EventHandler(this.ptb_star3_MouseLeave);
            // 
            // ptb_star2
            // 
            this.ptb_star2.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_star_black;
            this.ptb_star2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_star2.Location = new System.Drawing.Point(714, 129);
            this.ptb_star2.Name = "ptb_star2";
            this.ptb_star2.Size = new System.Drawing.Size(33, 33);
            this.ptb_star2.TabIndex = 41;
            this.ptb_star2.TabStop = false;
            this.ptb_star2.Click += new System.EventHandler(this.ptb_star2_Click);
            this.ptb_star2.MouseEnter += new System.EventHandler(this.ptb_star2_MouseEnter);
            this.ptb_star2.MouseLeave += new System.EventHandler(this.ptb_star2_MouseLeave);
            // 
            // ptb_star1
            // 
            this.ptb_star1.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_star_black;
            this.ptb_star1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_star1.Location = new System.Drawing.Point(664, 129);
            this.ptb_star1.Name = "ptb_star1";
            this.ptb_star1.Size = new System.Drawing.Size(33, 33);
            this.ptb_star1.TabIndex = 40;
            this.ptb_star1.TabStop = false;
            this.ptb_star1.Click += new System.EventHandler(this.ptb_star1_Click);
            this.ptb_star1.MouseEnter += new System.EventHandler(this.ptb_star1_MouseEnter);
            this.ptb_star1.MouseLeave += new System.EventHandler(this.ptb_star1_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 39;
            this.label4.Text = "Stars:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.fpnl_cmt);
            this.panel1.Location = new System.Drawing.Point(392, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 543);
            this.panel1.TabIndex = 55;
            // 
            // fpnl_cmt
            // 
            this.fpnl_cmt.BackColor = System.Drawing.Color.White;
            this.fpnl_cmt.Location = new System.Drawing.Point(5, 5);
            this.fpnl_cmt.Name = "fpnl_cmt";
            this.fpnl_cmt.Size = new System.Drawing.Size(1203, 533);
            this.fpnl_cmt.TabIndex = 56;
            // 
            // btn_postcomment
            // 
            this.btn_postcomment.BackColor = System.Drawing.Color.Green;
            this.btn_postcomment.BackgroundColor = System.Drawing.Color.Green;
            this.btn_postcomment.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_postcomment.BorderRadius = 20;
            this.btn_postcomment.BorderSize = 0;
            this.btn_postcomment.FlatAppearance.BorderSize = 0;
            this.btn_postcomment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_postcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_postcomment.ForeColor = System.Drawing.Color.White;
            this.btn_postcomment.Location = new System.Drawing.Point(926, 321);
            this.btn_postcomment.Name = "btn_postcomment";
            this.btn_postcomment.Size = new System.Drawing.Size(236, 50);
            this.btn_postcomment.TabIndex = 53;
            this.btn_postcomment.Text = "Post comment";
            this.btn_postcomment.TextColor = System.Drawing.Color.White;
            this.btn_postcomment.UseVisualStyleBackColor = false;
            this.btn_postcomment.Click += new System.EventHandler(this.btn_postcomment_Click);
            // 
            // txt_cmtname
            // 
            this.txt_cmtname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cmtname.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_cmtname.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_cmtname.BorderSize = 2;
            this.txt_cmtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmtname.ForeColor = System.Drawing.Color.Black;
            this.txt_cmtname.Location = new System.Drawing.Point(664, 178);
            this.txt_cmtname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cmtname.Multiline = false;
            this.txt_cmtname.Name = "txt_cmtname";
            this.txt_cmtname.Padding = new System.Windows.Forms.Padding(7);
            this.txt_cmtname.PasswordChar = false;
            this.txt_cmtname.Size = new System.Drawing.Size(392, 35);
            this.txt_cmtname.TabIndex = 49;
            this.txt_cmtname.Texts = "";
            this.txt_cmtname.UnderlineStyle = false;
            // 
            // Uct_Cus_BookInfo_Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_postcomment);
            this.Controls.Add(this.rtb_cmttext);
            this.Controls.Add(this.ptb_cmtpic);
            this.Controls.Add(this.txt_cmtname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rad_female);
            this.Controls.Add(this.rad_male);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ptb_star5);
            this.Controls.Add(this.ptb_star4);
            this.Controls.Add(this.ptb_star3);
            this.Controls.Add(this.ptb_star2);
            this.Controls.Add(this.ptb_star1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_title);
            this.Name = "Uct_Cus_BookInfo_Comment";
            this.Size = new System.Drawing.Size(2048, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cmtpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_star1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label10;
        private View.CustomButton btn_postcomment;
        private System.Windows.Forms.RichTextBox rtb_cmttext;
        private System.Windows.Forms.PictureBox ptb_cmtpic;
        private Uct_textbox txt_cmtname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptb_star5;
        private System.Windows.Forms.PictureBox ptb_star4;
        private System.Windows.Forms.PictureBox ptb_star3;
        private System.Windows.Forms.PictureBox ptb_star2;
        private System.Windows.Forms.PictureBox ptb_star1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnl_cmt;
    }
}

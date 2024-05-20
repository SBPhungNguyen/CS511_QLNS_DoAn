namespace CS511_Project_QLNS
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guest = new CS511_Project_QLNS.View.CustomButton();
            this.txt_pass = new CS511_Project_QLNS.Uct_textbox();
            this.txt_name = new CS511_Project_QLNS.Uct_textbox();
            this.btn_signin = new CS511_Project_QLNS.View.CustomButton();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_LogIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btn_guest);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.btn_signin);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_LogIn);
            this.panel1.Location = new System.Drawing.Point(359, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 332);
            this.panel1.TabIndex = 3;
            // 
            // btn_guest
            // 
            this.btn_guest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_guest.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btn_guest.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_guest.BorderRadius = 40;
            this.btn_guest.BorderSize = 1;
            this.btn_guest.FlatAppearance.BorderSize = 0;
            this.btn_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guest.ForeColor = System.Drawing.Color.Black;
            this.btn_guest.Location = new System.Drawing.Point(62, 274);
            this.btn_guest.Name = "btn_guest";
            this.btn_guest.Size = new System.Drawing.Size(272, 40);
            this.btn_guest.TabIndex = 24;
            this.btn_guest.Text = "Continue without sign up";
            this.btn_guest.TextColor = System.Drawing.Color.Black;
            this.btn_guest.UseVisualStyleBackColor = false;
            this.btn_guest.Click += new System.EventHandler(this.btn_guest_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pass.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_pass.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_pass.BorderSize = 2;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.DimGray;
            this.txt_pass.Location = new System.Drawing.Point(138, 115);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(7);
            this.txt_pass.PasswordChar = true;
            this.txt_pass.Size = new System.Drawing.Size(233, 35);
            this.txt_pass.TabIndex = 23;
            this.txt_pass.Texts = "";
            this.txt_pass.UnderlineStyle = true;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_name.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.DimGray;
            this.txt_name.Location = new System.Drawing.Point(138, 70);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7);
            this.txt_name.PasswordChar = false;
            this.txt_name.Size = new System.Drawing.Size(233, 35);
            this.txt_name.TabIndex = 22;
            this.txt_name.Texts = "";
            this.txt_name.UnderlineStyle = true;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.Green;
            this.btn_signin.BackgroundColor = System.Drawing.Color.Green;
            this.btn_signin.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_signin.BorderRadius = 40;
            this.btn_signin.BorderSize = 0;
            this.btn_signin.FlatAppearance.BorderSize = 0;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.White;
            this.btn_signin.Location = new System.Drawing.Point(87, 170);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(230, 40);
            this.btn_signin.TabIndex = 21;
            this.btn_signin.Text = "Sign in";
            this.btn_signin.TextColor = System.Drawing.Color.White;
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(356, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Or if you are a customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(54, 75);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(70, 24);
            this.lbl_email.TabIndex = 15;
            this.lbl_email.Text = "Name:";
            // 
            // lbl_LogIn
            // 
            this.lbl_LogIn.AutoSize = true;
            this.lbl_LogIn.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogIn.ForeColor = System.Drawing.Color.Green;
            this.lbl_LogIn.Location = new System.Drawing.Point(122, 19);
            this.lbl_LogIn.Name = "lbl_LogIn";
            this.lbl_LogIn.Size = new System.Drawing.Size(155, 40);
            this.lbl_LogIn.TabIndex = 14;
            this.lbl_LogIn.Text = "SIGN IN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.TheGreenBook;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 332);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.DarkGreenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_LogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Uct_textbox txt_pass;
        private Uct_textbox txt_name;
        private View.CustomButton btn_signin;
        private View.CustomButton btn_guest;
    }
}
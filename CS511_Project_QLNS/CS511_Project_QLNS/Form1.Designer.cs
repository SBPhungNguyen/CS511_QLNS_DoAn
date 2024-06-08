namespace CS511_Project_QLNS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.customPictureBox1 = new CS511_Project_QLNS.View.CustomPictureBox();
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.pnl_UserName = new System.Windows.Forms.Panel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_logout = new CS511_Project_QLNS.View.CustomButton();
            this.btn_chat = new CS511_Project_QLNS.View.CustomButton();
            this.btn_receipt = new CS511_Project_QLNS.View.CustomButton();
            this.btn_cart = new CS511_Project_QLNS.View.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_home = new CS511_Project_QLNS.View.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.pnl_UserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 40);
            this.panel1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1263, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Green;
            this.lbl_title.Location = new System.Drawing.Point(308, 77);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(116, 40);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "HOME";
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_user2;
            this.customPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPictureBox1.Border = 1;
            this.customPictureBox1.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox1.BorderStyle1 = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.customPictureBox1.ColorBorder = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.ColorBorder2 = System.Drawing.Color.HotPink;
            this.customPictureBox1.Gradiant = 50F;
            this.customPictureBox1.Location = new System.Drawing.Point(70, 134);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(125, 115);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 2;
            this.customPictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.customPanel1.BorderColor = System.Drawing.Color.Lime;
            this.customPanel1.Controls.Add(this.pnl_UserName);
            this.customPanel1.Controls.Add(this.btn_logout);
            this.customPanel1.Controls.Add(this.btn_chat);
            this.customPanel1.Controls.Add(this.btn_receipt);
            this.customPanel1.Controls.Add(this.btn_cart);
            this.customPanel1.Controls.Add(this.panel2);
            this.customPanel1.Controls.Add(this.btn_home);
            this.customPanel1.Location = new System.Drawing.Point(-9, 189);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 20;
            this.customPanel1.Size = new System.Drawing.Size(270, 611);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.Thickness = 1F;
            // 
            // pnl_UserName
            // 
            this.pnl_UserName.Controls.Add(this.lbl_UserName);
            this.pnl_UserName.Location = new System.Drawing.Point(21, 86);
            this.pnl_UserName.Name = "pnl_UserName";
            this.pnl_UserName.Size = new System.Drawing.Size(243, 45);
            this.pnl_UserName.TabIndex = 10;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_UserName.Location = new System.Drawing.Point(0, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(243, 45);
            this.lbl_UserName.TabIndex = 11;
            this.lbl_UserName.Text = "Guest";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_logout.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_logout.BorderRadius = 0;
            this.btn_logout.BorderSize = 0;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(8, 548);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(259, 63);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.TextColor = System.Drawing.Color.White;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_chat
            // 
            this.btn_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_chat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_chat.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_chat.BorderRadius = 0;
            this.btn_chat.BorderSize = 0;
            this.btn_chat.FlatAppearance.BorderSize = 0;
            this.btn_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chat.ForeColor = System.Drawing.Color.White;
            this.btn_chat.Location = new System.Drawing.Point(4, 358);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(263, 63);
            this.btn_chat.TabIndex = 8;
            this.btn_chat.Text = "Chat";
            this.btn_chat.TextColor = System.Drawing.Color.White;
            this.btn_chat.UseVisualStyleBackColor = false;
            this.btn_chat.Click += new System.EventHandler(this.btn_chat_Click);
            // 
            // btn_receipt
            // 
            this.btn_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_receipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_receipt.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_receipt.BorderRadius = 0;
            this.btn_receipt.BorderSize = 0;
            this.btn_receipt.FlatAppearance.BorderSize = 0;
            this.btn_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receipt.ForeColor = System.Drawing.Color.White;
            this.btn_receipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_receipt.Location = new System.Drawing.Point(4, 296);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(263, 63);
            this.btn_receipt.TabIndex = 7;
            this.btn_receipt.Text = "Receipt Search";
            this.btn_receipt.TextColor = System.Drawing.Color.White;
            this.btn_receipt.UseVisualStyleBackColor = false;
            this.btn_receipt.Click += new System.EventHandler(this.btn_receipt_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_cart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_cart.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_cart.BorderRadius = 0;
            this.btn_cart.BorderSize = 0;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.ForeColor = System.Drawing.Color.White;
            this.btn_cart.Location = new System.Drawing.Point(4, 233);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(263, 63);
            this.btn_cart.TabIndex = 6;
            this.btn_cart.Text = "Cart";
            this.btn_cart.TextColor = System.Drawing.Color.White;
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(-5, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 2);
            this.panel2.TabIndex = 5;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_home.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.btn_home.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_home.BorderRadius = 0;
            this.btn_home.BorderSize = 0;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(7, 170);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(260, 63);
            this.btn_home.TabIndex = 4;
            this.btn_home.Text = "Home";
            this.btn_home.TextColor = System.Drawing.Color.White;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.pnl_UserName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private View.CustomPictureBox customPictureBox1;
        private View.CustomPanel customPanel1;
        private View.CustomButton btn_home;
        private System.Windows.Forms.Panel panel2;
        private View.CustomButton btn_cart;
        private View.CustomButton btn_chat;
        private View.CustomButton btn_receipt;
        private View.CustomButton btn_logout;
        private System.Windows.Forms.Panel pnl_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_title;
    }
}


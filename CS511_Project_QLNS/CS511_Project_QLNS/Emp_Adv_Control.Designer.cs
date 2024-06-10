namespace CS511_Project_QLNS
{
    partial class Emp_Adv_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_Adv_Control));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_banner = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_url = new CS511_Project_QLNS.Uct_textbox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.customButton1 = new CS511_Project_QLNS.View.CustomButton();
            this.customButton2 = new CS511_Project_QLNS.View.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
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
            this.panel1.TabIndex = 10;
            // 
            // ptb_banner
            // 
            this.ptb_banner.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_banner;
            this.ptb_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_banner.Location = new System.Drawing.Point(104, 173);
            this.ptb_banner.Name = "ptb_banner";
            this.ptb_banner.Size = new System.Drawing.Size(1076, 292);
            this.ptb_banner.TabIndex = 11;
            this.ptb_banner.TabStop = false;
            this.ptb_banner.Click += new System.EventHandler(this.ptb_banner_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1266, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "URL:";
            // 
            // txt_url
            // 
            this.txt_url.BackColor = System.Drawing.SystemColors.Window;
            this.txt_url.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_url.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_url.BorderSize = 2;
            this.txt_url.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_url.ForeColor = System.Drawing.Color.Black;
            this.txt_url.Location = new System.Drawing.Point(231, 529);
            this.txt_url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_url.Multiline = false;
            this.txt_url.Name = "txt_url";
            this.txt_url.Padding = new System.Windows.Forms.Padding(7);
            this.txt_url.PasswordChar = false;
            this.txt_url.Size = new System.Drawing.Size(949, 47);
            this.txt_url.TabIndex = 13;
            this.txt_url.Texts = "";
            this.txt_url.UnderlineStyle = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Green;
            this.lbl_title.Location = new System.Drawing.Point(464, 88);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(402, 52);
            this.lbl_title.TabIndex = 25;
            this.lbl_title.Text = "CUSTOM BANNER";
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
            this.customButton1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(104, 713);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(402, 60);
            this.customButton1.TabIndex = 26;
            this.customButton1.Text = "Update Banner";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Orange;
            this.customButton2.BackgroundColor = System.Drawing.Color.Orange;
            this.customButton2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.customButton2.Location = new System.Drawing.Point(778, 713);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(402, 60);
            this.customButton2.TabIndex = 27;
            this.customButton2.Text = "Delete the banner";
            this.customButton2.TextColor = System.Drawing.Color.MidnightBlue;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // Emp_Adv_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_banner);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_Adv_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uct_Emp_Adv_Control";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox ptb_banner;
        private System.Windows.Forms.Label label1;
        private Uct_textbox txt_url;
        private System.Windows.Forms.Label lbl_title;
        private View.CustomButton customButton1;
        private View.CustomButton customButton2;
    }
}
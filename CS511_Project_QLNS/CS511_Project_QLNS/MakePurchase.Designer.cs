namespace CS511_Project_QLNS
{
    partial class MakePurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakePurchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_name = new CS511_Project_QLNS.Uct_textbox();
            this.txt_address = new CS511_Project_QLNS.Uct_textbox();
            this.txt_email = new CS511_Project_QLNS.Uct_textbox();
            this.txt_visa = new CS511_Project_QLNS.Uct_textbox();
            this.txt_secure = new CS511_Project_QLNS.Uct_textbox();
            this.lbl_LogIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_purchase = new CS511_Project_QLNS.View.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(862, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Visa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Secure number:";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_name.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Location = new System.Drawing.Point(186, 108);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7);
            this.txt_name.PasswordChar = false;
            this.txt_name.Size = new System.Drawing.Size(296, 35);
            this.txt_name.TabIndex = 19;
            this.txt_name.Texts = "";
            this.txt_name.UnderlineStyle = true;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.Window;
            this.txt_address.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_address.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_address.BorderSize = 2;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(186, 161);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Multiline = false;
            this.txt_address.Name = "txt_address";
            this.txt_address.Padding = new System.Windows.Forms.Padding(7);
            this.txt_address.PasswordChar = false;
            this.txt_address.Size = new System.Drawing.Size(296, 35);
            this.txt_address.TabIndex = 20;
            this.txt_address.Texts = "";
            this.txt_address.UnderlineStyle = true;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_email.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_email.BorderSize = 2;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(186, 217);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(7);
            this.txt_email.PasswordChar = false;
            this.txt_email.Size = new System.Drawing.Size(296, 35);
            this.txt_email.TabIndex = 21;
            this.txt_email.Texts = "";
            this.txt_email.UnderlineStyle = true;
            // 
            // txt_visa
            // 
            this.txt_visa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_visa.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_visa.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_visa.BorderSize = 2;
            this.txt_visa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visa.ForeColor = System.Drawing.Color.Black;
            this.txt_visa.Location = new System.Drawing.Point(186, 267);
            this.txt_visa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_visa.Multiline = false;
            this.txt_visa.Name = "txt_visa";
            this.txt_visa.Padding = new System.Windows.Forms.Padding(7);
            this.txt_visa.PasswordChar = false;
            this.txt_visa.Size = new System.Drawing.Size(296, 35);
            this.txt_visa.TabIndex = 22;
            this.txt_visa.Texts = "";
            this.txt_visa.UnderlineStyle = true;
            // 
            // txt_secure
            // 
            this.txt_secure.BackColor = System.Drawing.SystemColors.Window;
            this.txt_secure.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_secure.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_secure.BorderSize = 2;
            this.txt_secure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secure.ForeColor = System.Drawing.Color.Black;
            this.txt_secure.Location = new System.Drawing.Point(728, 267);
            this.txt_secure.Margin = new System.Windows.Forms.Padding(4);
            this.txt_secure.Multiline = false;
            this.txt_secure.Name = "txt_secure";
            this.txt_secure.Padding = new System.Windows.Forms.Padding(7);
            this.txt_secure.PasswordChar = false;
            this.txt_secure.Size = new System.Drawing.Size(101, 35);
            this.txt_secure.TabIndex = 23;
            this.txt_secure.Texts = "";
            this.txt_secure.UnderlineStyle = true;
            // 
            // lbl_LogIn
            // 
            this.lbl_LogIn.AutoSize = true;
            this.lbl_LogIn.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogIn.ForeColor = System.Drawing.Color.Green;
            this.lbl_LogIn.Location = new System.Drawing.Point(314, 56);
            this.lbl_LogIn.Name = "lbl_LogIn";
            this.lbl_LogIn.Size = new System.Drawing.Size(293, 40);
            this.lbl_LogIn.TabIndex = 24;
            this.lbl_LogIn.Text = "PURCHASE INFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total amount:";
            // 
            // lbl_total
            // 
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(0, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(156, 35);
            this.lbl_total.TabIndex = 26;
            this.lbl_total.Text = "12312931 ";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.Green;
            this.btn_purchase.BackgroundColor = System.Drawing.Color.Green;
            this.btn_purchase.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_purchase.BorderRadius = 40;
            this.btn_purchase.BorderSize = 0;
            this.btn_purchase.FlatAppearance.BorderSize = 0;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchase.ForeColor = System.Drawing.Color.White;
            this.btn_purchase.Location = new System.Drawing.Point(321, 375);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(286, 40);
            this.btn_purchase.TabIndex = 27;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.TextColor = System.Drawing.Color.White;
            this.btn_purchase.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Location = new System.Drawing.Point(472, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 35);
            this.panel2.TabIndex = 28;
            // 
            // MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_LogIn);
            this.Controls.Add(this.txt_secure);
            this.Controls.Add(this.txt_visa);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakePurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakePurchase";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Uct_textbox txt_name;
        private Uct_textbox txt_address;
        private Uct_textbox txt_email;
        private Uct_textbox txt_visa;
        private Uct_textbox txt_secure;
        private System.Windows.Forms.Label lbl_LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private View.CustomButton btn_purchase;
        private System.Windows.Forms.Panel panel2;
    }
}
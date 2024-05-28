namespace CS511_Project_QLNS
{
    partial class Emp_CashierAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_CashierAdd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_manager = new System.Windows.Forms.RadioButton();
            this.radio_cashier = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uct_textbox3 = new CS511_Project_QLNS.Uct_textbox();
            this.uct_textbox2 = new CS511_Project_QLNS.Uct_textbox();
            this.uct_textbox1 = new CS511_Project_QLNS.Uct_textbox();
            this.txt_pass = new CS511_Project_QLNS.Uct_textbox();
            this.btn_cancel = new CS511_Project_QLNS.View.CustomButton();
            this.btn_update = new CS511_Project_QLNS.View.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 40);
            this.panel1.TabIndex = 51;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(566, 5);
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
            this.lbl_title.Location = new System.Drawing.Point(165, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(277, 40);
            this.lbl_title.TabIndex = 50;
            this.lbl_title.Text = "EMPLOYEE ADD";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(242, 383);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(63, 22);
            this.lbl_id.TabIndex = 60;
            this.lbl_id.Text = "Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "ID:";
            // 
            // radio_manager
            // 
            this.radio_manager.AutoSize = true;
            this.radio_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_manager.Location = new System.Drawing.Point(246, 622);
            this.radio_manager.Name = "radio_manager";
            this.radio_manager.Size = new System.Drawing.Size(108, 26);
            this.radio_manager.TabIndex = 63;
            this.radio_manager.TabStop = true;
            this.radio_manager.Text = "Manager";
            this.radio_manager.UseVisualStyleBackColor = true;
            // 
            // radio_cashier
            // 
            this.radio_cashier.AutoSize = true;
            this.radio_cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_cashier.Location = new System.Drawing.Point(246, 579);
            this.radio_cashier.Name = "radio_cashier";
            this.radio_cashier.Size = new System.Drawing.Size(118, 26);
            this.radio_cashier.TabIndex = 62;
            this.radio_cashier.TabStop = true;
            this.radio_cashier.Text = "Employee";
            this.radio_cashier.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 61;
            this.label2.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 56;
            this.label5.Text = "Date of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Name:";
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_img.BackgroundImage")));
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(207, 113);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(188, 241);
            this.ptb_img.TabIndex = 52;
            this.ptb_img.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Password:";
            // 
            // uct_textbox3
            // 
            this.uct_textbox3.BackColor = System.Drawing.SystemColors.Window;
            this.uct_textbox3.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.uct_textbox3.BorderFocusColor = System.Drawing.Color.Green;
            this.uct_textbox3.BorderSize = 2;
            this.uct_textbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uct_textbox3.ForeColor = System.Drawing.Color.Black;
            this.uct_textbox3.Location = new System.Drawing.Point(246, 660);
            this.uct_textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.uct_textbox3.Multiline = false;
            this.uct_textbox3.Name = "uct_textbox3";
            this.uct_textbox3.Padding = new System.Windows.Forms.Padding(7);
            this.uct_textbox3.PasswordChar = false;
            this.uct_textbox3.Size = new System.Drawing.Size(288, 35);
            this.uct_textbox3.TabIndex = 68;
            this.uct_textbox3.Texts = "";
            this.uct_textbox3.UnderlineStyle = true;
            // 
            // uct_textbox2
            // 
            this.uct_textbox2.BackColor = System.Drawing.SystemColors.Window;
            this.uct_textbox2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.uct_textbox2.BorderFocusColor = System.Drawing.Color.Green;
            this.uct_textbox2.BorderSize = 2;
            this.uct_textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uct_textbox2.ForeColor = System.Drawing.Color.Black;
            this.uct_textbox2.Location = new System.Drawing.Point(246, 521);
            this.uct_textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.uct_textbox2.Multiline = false;
            this.uct_textbox2.Name = "uct_textbox2";
            this.uct_textbox2.Padding = new System.Windows.Forms.Padding(7);
            this.uct_textbox2.PasswordChar = false;
            this.uct_textbox2.Size = new System.Drawing.Size(288, 35);
            this.uct_textbox2.TabIndex = 66;
            this.uct_textbox2.Texts = "";
            this.uct_textbox2.UnderlineStyle = true;
            // 
            // uct_textbox1
            // 
            this.uct_textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.uct_textbox1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.uct_textbox1.BorderFocusColor = System.Drawing.Color.Green;
            this.uct_textbox1.BorderSize = 2;
            this.uct_textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uct_textbox1.ForeColor = System.Drawing.Color.Black;
            this.uct_textbox1.Location = new System.Drawing.Point(246, 469);
            this.uct_textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.uct_textbox1.Multiline = false;
            this.uct_textbox1.Name = "uct_textbox1";
            this.uct_textbox1.Padding = new System.Windows.Forms.Padding(7);
            this.uct_textbox1.PasswordChar = false;
            this.uct_textbox1.Size = new System.Drawing.Size(288, 35);
            this.uct_textbox1.TabIndex = 65;
            this.uct_textbox1.Texts = "";
            this.uct_textbox1.UnderlineStyle = true;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pass.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_pass.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_pass.BorderSize = 2;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(246, 416);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(7);
            this.txt_pass.PasswordChar = false;
            this.txt_pass.Size = new System.Drawing.Size(288, 35);
            this.txt_pass.TabIndex = 64;
            this.txt_pass.Texts = "";
            this.txt_pass.UnderlineStyle = true;
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
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(364, 736);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(170, 40);
            this.btn_cancel.TabIndex = 83;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextColor = System.Drawing.Color.Black;
            this.btn_cancel.UseVisualStyleBackColor = false;
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
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(83, 736);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(170, 40);
            this.btn_update.TabIndex = 82;
            this.btn_update.Text = "Add";
            this.btn_update.TextColor = System.Drawing.Color.White;
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // Emp_CashierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.uct_textbox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uct_textbox2);
            this.Controls.Add(this.uct_textbox1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ptb_img);
            this.Controls.Add(this.radio_manager);
            this.Controls.Add(this.radio_cashier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emp_CashierAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emp_CashierAdd";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptb_img;
        private System.Windows.Forms.RadioButton radio_manager;
        private System.Windows.Forms.RadioButton radio_cashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Uct_textbox txt_pass;
        private Uct_textbox uct_textbox1;
        private Uct_textbox uct_textbox2;
        private Uct_textbox uct_textbox3;
        private System.Windows.Forms.Label label4;
        private View.CustomButton btn_cancel;
        private View.CustomButton btn_update;
    }
}
namespace CS511_Project_QLNS
{
    partial class Uct_Customer_ReceiptSearch
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
            this.components = new System.ComponentModel.Container();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_camera = new CS511_Project_QLNS.View.CustomButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_choosepic = new CS511_Project_QLNS.View.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sumprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fpnl_receipt = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_picture;
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(564, 4);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(200, 200);
            this.ptb_img.TabIndex = 0;
            this.ptb_img.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.ptb_img);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1721, 216);
            this.panel1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btn_camera);
            this.panel5.Location = new System.Drawing.Point(889, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 60);
            this.panel5.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Scan QR:";
            // 
            // btn_camera
            // 
            this.btn_camera.BackColor = System.Drawing.Color.Green;
            this.btn_camera.BackgroundColor = System.Drawing.Color.Green;
            this.btn_camera.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_camera.BorderRadius = 20;
            this.btn_camera.BorderSize = 0;
            this.btn_camera.FlatAppearance.BorderSize = 0;
            this.btn_camera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camera.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camera.ForeColor = System.Drawing.Color.White;
            this.btn_camera.Location = new System.Drawing.Point(203, 5);
            this.btn_camera.Name = "btn_camera";
            this.btn_camera.Size = new System.Drawing.Size(267, 50);
            this.btn_camera.TabIndex = 3;
            this.btn_camera.Text = "Turn on Camera";
            this.btn_camera.TextColor = System.Drawing.Color.White;
            this.btn_camera.UseVisualStyleBackColor = false;
            this.btn_camera.Click += new System.EventHandler(this.btn_camera_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btn_choosepic);
            this.panel4.Location = new System.Drawing.Point(889, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 60);
            this.panel4.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "Upload QR:";
            // 
            // btn_choosepic
            // 
            this.btn_choosepic.BackColor = System.Drawing.Color.Green;
            this.btn_choosepic.BackgroundColor = System.Drawing.Color.Green;
            this.btn_choosepic.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_choosepic.BorderRadius = 20;
            this.btn_choosepic.BorderSize = 0;
            this.btn_choosepic.FlatAppearance.BorderSize = 0;
            this.btn_choosepic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_choosepic.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choosepic.ForeColor = System.Drawing.Color.White;
            this.btn_choosepic.Location = new System.Drawing.Point(203, 4);
            this.btn_choosepic.Name = "btn_choosepic";
            this.btn_choosepic.Size = new System.Drawing.Size(267, 50);
            this.btn_choosepic.TabIndex = 1;
            this.btn_choosepic.Text = "Choose Picture";
            this.btn_choosepic.TextColor = System.Drawing.Color.White;
            this.btn_choosepic.UseVisualStyleBackColor = false;
            this.btn_choosepic.Click += new System.EventHandler(this.btn_choosepic_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.lbl_sumprice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.lbl_code);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fpnl_receipt);
            this.panel2.Controls.Add(this.customPanel1);
            this.panel2.Location = new System.Drawing.Point(3, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1721, 656);
            this.panel2.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(255, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 28);
            this.lbl_name.TabIndex = 15;
            // 
            // lbl_sumprice
            // 
            this.lbl_sumprice.AutoSize = true;
            this.lbl_sumprice.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumprice.ForeColor = System.Drawing.Color.Red;
            this.lbl_sumprice.Location = new System.Drawing.Point(1412, 602);
            this.lbl_sumprice.Name = "lbl_sumprice";
            this.lbl_sumprice.Size = new System.Drawing.Size(38, 40);
            this.lbl_sumprice.TabIndex = 14;
            this.lbl_sumprice.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1260, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(82)))));
            this.panel3.Location = new System.Drawing.Point(3, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1720, 10);
            this.panel3.TabIndex = 12;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(812, 21);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 28);
            this.lbl_date.TabIndex = 11;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(255, 21);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(0, 28);
            this.lbl_code.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label8.Location = new System.Drawing.Point(699, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label6.Location = new System.Drawing.Point(131, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code:";
            // 
            // fpnl_receipt
            // 
            this.fpnl_receipt.Location = new System.Drawing.Point(4, 178);
            this.fpnl_receipt.Name = "fpnl_receipt";
            this.fpnl_receipt.Size = new System.Drawing.Size(1702, 403);
            this.fpnl_receipt.TabIndex = 3;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(171)))), ((int)(((byte)(116)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(69)))));
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Location = new System.Drawing.Point(7, 107);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 5;
            this.customPanel1.Size = new System.Drawing.Size(1663, 65);
            this.customPanel1.TabIndex = 2;
            this.customPanel1.Thickness = 2F;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label5.Location = new System.Drawing.Point(1385, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label2.Location = new System.Drawing.Point(259, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label4.Location = new System.Drawing.Point(1033, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label3.Location = new System.Drawing.Point(690, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Uct_Customer_ReceiptSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Uct_Customer_ReceiptSearch";
            this.Size = new System.Drawing.Size(1740, 930);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_img;
        private View.CustomButton btn_choosepic;
        private View.CustomButton btn_camera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel fpnl_receipt;
        private View.CustomPanel customPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_sumprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
    }
}

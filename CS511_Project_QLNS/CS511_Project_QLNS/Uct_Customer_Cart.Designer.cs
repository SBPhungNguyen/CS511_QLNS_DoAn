namespace CS511_Project_QLNS
{
    partial class Uct_Customer_Cart
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
            this.customPanel1 = new CS511_Project_QLNS.View.CustomPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fpnl_cart = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_buy = new CS511_Project_QLNS.View.CustomButton();
            this.lbl_sumprice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(171)))), ((int)(((byte)(116)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(69)))));
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Location = new System.Drawing.Point(3, 7);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 5;
            this.customPanel1.Size = new System.Drawing.Size(940, 45);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.Thickness = 2F;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(756, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // fpnl_cart
            // 
            this.fpnl_cart.BackColor = System.Drawing.SystemColors.Window;
            this.fpnl_cart.Location = new System.Drawing.Point(0, 61);
            this.fpnl_cart.Name = "fpnl_cart";
            this.fpnl_cart.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.fpnl_cart.Size = new System.Drawing.Size(980, 506);
            this.fpnl_cart.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btn_buy);
            this.panel1.Controls.Add(this.lbl_sumprice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 102);
            this.panel1.TabIndex = 33;
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.Green;
            this.btn_buy.BackgroundColor = System.Drawing.Color.Green;
            this.btn_buy.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_buy.BorderRadius = 20;
            this.btn_buy.BorderSize = 0;
            this.btn_buy.FlatAppearance.BorderSize = 0;
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(605, 33);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(271, 45);
            this.btn_buy.TabIndex = 2;
            this.btn_buy.Text = "Purchase";
            this.btn_buy.TextColor = System.Drawing.Color.White;
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // lbl_sumprice
            // 
            this.lbl_sumprice.AutoSize = true;
            this.lbl_sumprice.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sumprice.ForeColor = System.Drawing.Color.Red;
            this.lbl_sumprice.Location = new System.Drawing.Point(234, 40);
            this.lbl_sumprice.Name = "lbl_sumprice";
            this.lbl_sumprice.Size = new System.Drawing.Size(27, 28);
            this.lbl_sumprice.TabIndex = 1;
            this.lbl_sumprice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // Uct_Customer_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpnl_cart);
            this.Controls.Add(this.customPanel1);
            this.Name = "Uct_Customer_Cart";
            this.Size = new System.Drawing.Size(980, 675);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomPanel customPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel fpnl_cart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_sumprice;
        private System.Windows.Forms.Label label1;
        private View.CustomButton btn_buy;
    }
}

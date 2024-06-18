namespace CS511_Project_QLNS
{
    partial class Uct_Cus_Book
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.ptb_cart = new System.Windows.Forms.PictureBox();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_price);
            this.panel2.Location = new System.Drawing.Point(63, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 32);
            this.panel2.TabIndex = 7;
            // 
            // lbl_price
            // 
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_price.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.Red;
            this.lbl_price.Location = new System.Drawing.Point(0, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(160, 32);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "label2";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            this.lbl_price.MouseEnter += new System.EventHandler(this.Uct_Emp_Book_MouseEnter);
            this.lbl_price.MouseLeave += new System.EventHandler(this.Uct_Emp_Book_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(19, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 73);
            this.panel1.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(250, 73);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            this.lbl_name.MouseEnter += new System.EventHandler(this.Uct_Emp_Book_MouseEnter);
            this.lbl_name.MouseLeave += new System.EventHandler(this.Uct_Emp_Book_MouseLeave);
            // 
            // ptb_cart
            // 
            this.ptb_cart.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_cart;
            this.ptb_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_cart.Location = new System.Drawing.Point(248, 8);
            this.ptb_cart.Name = "ptb_cart";
            this.ptb_cart.Size = new System.Drawing.Size(30, 30);
            this.ptb_cart.TabIndex = 8;
            this.ptb_cart.TabStop = false;
            this.ptb_cart.Click += new System.EventHandler(this.ptb_cart_Click);
            this.ptb_cart.MouseEnter += new System.EventHandler(this.Uct_Emp_Book_MouseEnter);
            this.ptb_cart.MouseLeave += new System.EventHandler(this.Uct_Emp_Book_MouseLeave);
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(76, 40);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(140, 180);
            this.ptb_img.TabIndex = 5;
            this.ptb_img.TabStop = false;
            this.ptb_img.Click += new System.EventHandler(this.ptb_img_Click);
            this.ptb_img.MouseEnter += new System.EventHandler(this.Uct_Emp_Book_MouseEnter);
            this.ptb_img.MouseLeave += new System.EventHandler(this.Uct_Emp_Book_MouseLeave);
            // 
            // Uct_Cus_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ptb_cart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_img);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 45, 10);
            this.Name = "Uct_Cus_Book";
            this.Size = new System.Drawing.Size(285, 400);
            this.Click += new System.EventHandler(this.Uct_Cus_Book_Click);
            this.MouseEnter += new System.EventHandler(this.Uct_Emp_Book_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Uct_Emp_Book_MouseLeave);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_cart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox ptb_img;
    }
}

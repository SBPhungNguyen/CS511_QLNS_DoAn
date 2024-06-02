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
            this.panel2.Location = new System.Drawing.Point(104, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 32);
            this.panel2.TabIndex = 7;
            // 
            // lbl_price
            // 
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.Purple;
            this.lbl_price.Location = new System.Drawing.Point(0, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(160, 32);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "label2";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(104, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 69);
            this.panel1.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(160, 69);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // ptb_cart
            // 
            this.ptb_cart.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_cart;
            this.ptb_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_cart.Location = new System.Drawing.Point(244, 4);
            this.ptb_cart.Name = "ptb_cart";
            this.ptb_cart.Size = new System.Drawing.Size(30, 30);
            this.ptb_cart.TabIndex = 8;
            this.ptb_cart.TabStop = false;
            this.ptb_cart.Click += new System.EventHandler(this.ptb_cart_Click);
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(14, 38);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(80, 95);
            this.ptb_img.TabIndex = 5;
            this.ptb_img.TabStop = false;
            this.ptb_img.Click += new System.EventHandler(this.ptb_img_Click);
            // 
            // Uct_Cus_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.ptb_cart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_img);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 35, 5);
            this.Name = "Uct_Cus_Book";
            this.Size = new System.Drawing.Size(280, 150);
            this.Click += new System.EventHandler(this.Uct_Cus_Book_Click);
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

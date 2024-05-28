namespace CS511_Project_QLNS
{
    partial class Uct_Emp_Cashier
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_role = new System.Windows.Forms.Label();
            this.ptb_update = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_update)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(160, 53);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_role);
            this.panel2.Location = new System.Drawing.Point(104, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 32);
            this.panel2.TabIndex = 16;
            // 
            // lbl_role
            // 
            this.lbl_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.Black;
            this.lbl_role.Location = new System.Drawing.Point(0, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(160, 32);
            this.lbl_role.TabIndex = 1;
            this.lbl_role.Text = "label2";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_role.Click += new System.EventHandler(this.lbl_role_Click);
            // 
            // ptb_update
            // 
            this.ptb_update.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_pencil;
            this.ptb_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_update.Location = new System.Drawing.Point(214, 7);
            this.ptb_update.Name = "ptb_update";
            this.ptb_update.Size = new System.Drawing.Size(25, 25);
            this.ptb_update.TabIndex = 18;
            this.ptb_update.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(108, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 53);
            this.panel1.TabIndex = 15;
            // 
            // ptb_delete
            // 
            this.ptb_delete.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_bin__2_;
            this.ptb_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_delete.Location = new System.Drawing.Point(248, 7);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(25, 25);
            this.ptb_delete.TabIndex = 17;
            this.ptb_delete.TabStop = false;
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(13, 44);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(80, 95);
            this.ptb_img.TabIndex = 14;
            this.ptb_img.TabStop = false;
            this.ptb_img.Click += new System.EventHandler(this.ptb_img_Click);
            // 
            // Uct_Emp_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptb_update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_img);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 35, 5);
            this.Name = "Uct_Emp_Cashier";
            this.Size = new System.Drawing.Size(280, 150);
            this.Click += new System.EventHandler(this.Uct_Emp_Cashier_Click);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_update)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.PictureBox ptb_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_img;
    }
}

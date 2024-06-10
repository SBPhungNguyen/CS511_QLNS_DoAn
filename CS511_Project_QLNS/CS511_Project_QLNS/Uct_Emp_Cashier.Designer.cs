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
            this.lbl_role = new System.Windows.Forms.Label();
            this.ptb_update = new System.Windows.Forms.PictureBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(207, 121);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(299, 59);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.Black;
            this.lbl_role.Location = new System.Drawing.Point(207, 186);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(299, 32);
            this.lbl_role.TabIndex = 1;
            this.lbl_role.Text = "label2";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_role.Click += new System.EventHandler(this.lbl_role_Click);
            // 
            // ptb_update
            // 
            this.ptb_update.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_pencil;
            this.ptb_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_update.Location = new System.Drawing.Point(440, 7);
            this.ptb_update.Name = "ptb_update";
            this.ptb_update.Size = new System.Drawing.Size(35, 35);
            this.ptb_update.TabIndex = 18;
            this.ptb_update.TabStop = false;
            this.ptb_update.Click += new System.EventHandler(this.ptb_update_Click);
            // 
            // ptb_delete
            // 
            this.ptb_delete.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_bin__2_;
            this.ptb_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_delete.Location = new System.Drawing.Point(487, 7);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(35, 35);
            this.ptb_delete.TabIndex = 17;
            this.ptb_delete.TabStop = false;
            this.ptb_delete.Click += new System.EventHandler(this.ptb_delete_Click);
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(33, 71);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(150, 150);
            this.ptb_img.TabIndex = 14;
            this.ptb_img.TabStop = false;
            this.ptb_img.Click += new System.EventHandler(this.ptb_img_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(209, 71);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(294, 39);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "label2";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // Uct_Emp_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.ptb_update);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_img);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 35, 5);
            this.Name = "Uct_Emp_Cashier";
            this.Size = new System.Drawing.Size(530, 250);
            this.Click += new System.EventHandler(this.Uct_Emp_Cashier_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.PictureBox ptb_update;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_img;
        private System.Windows.Forms.Label lbl_id;
    }
}

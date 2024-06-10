namespace CS511_Project_QLNS
{
    partial class Uct_Emp_Import
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.customPanel1.BorderColor = System.Drawing.Color.White;
            this.customPanel1.Controls.Add(this.lbl_id);
            this.customPanel1.Controls.Add(this.lbl_name);
            this.customPanel1.Controls.Add(this.lbl_date);
            this.customPanel1.Controls.Add(this.lbl_sum);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Location = new System.Drawing.Point(0, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 20;
            this.customPanel1.Size = new System.Drawing.Size(1690, 99);
            this.customPanel1.TabIndex = 2;
            this.customPanel1.Thickness = 0F;
            this.customPanel1.Click += new System.EventHandler(this.customPanel1_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(37, 30);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(161, 39);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "id";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(311, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(457, 66);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(901, 30);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(195, 39);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // lbl_sum
            // 
            this.lbl_sum.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sum.Location = new System.Drawing.Point(1243, 30);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(221, 39);
            this.lbl_sum.TabIndex = 6;
            this.lbl_sum.Text = "Sum";
            this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_sum.Click += new System.EventHandler(this.lbl_sum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_bin__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1592, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Uct_Emp_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel1);
            this.Name = "Uct_Emp_Import";
            this.Size = new System.Drawing.Size(1690, 110);
            this.Click += new System.EventHandler(this.Uct_Emp_Import_Click);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomPanel customPanel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

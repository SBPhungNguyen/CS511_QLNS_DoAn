namespace CS511_Project_QLNS
{
    partial class Uct_Emp_Book
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
            this.lbl_author = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.ptb_edit = new System.Windows.Forms.PictureBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_author);
            this.panel2.Location = new System.Drawing.Point(104, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 32);
            this.panel2.TabIndex = 11;
            // 
            // lbl_author
            // 
            this.lbl_author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.Color.Black;
            this.lbl_author.Location = new System.Drawing.Point(0, 0);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(160, 32);
            this.lbl_author.TabIndex = 1;
            this.lbl_author.Text = "label2";
            this.lbl_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_author.Click += new System.EventHandler(this.lbl_author_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(104, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 64);
            this.panel1.TabIndex = 10;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(160, 64);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label1";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // ptb_edit
            // 
            this.ptb_edit.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_pencil;
            this.ptb_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_edit.Location = new System.Drawing.Point(214, 6);
            this.ptb_edit.Name = "ptb_edit";
            this.ptb_edit.Size = new System.Drawing.Size(25, 25);
            this.ptb_edit.TabIndex = 13;
            this.ptb_edit.TabStop = false;
            this.ptb_edit.Click += new System.EventHandler(this.ptb_edit_Click);
            // 
            // ptb_delete
            // 
            this.ptb_delete.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_bin__2_;
            this.ptb_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_delete.Location = new System.Drawing.Point(247, 5);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(25, 25);
            this.ptb_delete.TabIndex = 12;
            this.ptb_delete.TabStop = false;
            this.ptb_delete.Click += new System.EventHandler(this.ptb_delete_Click);
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(22, 41);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(70, 95);
            this.ptb_img.TabIndex = 9;
            this.ptb_img.TabStop = false;
            this.ptb_img.Click += new System.EventHandler(this.ptb_img_Click);
            // 
            // Uct_Emp_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.ptb_edit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_img);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 35, 5);
            this.Name = "Uct_Emp_Book";
            this.Size = new System.Drawing.Size(280, 150);
            this.Click += new System.EventHandler(this.Uct_Emp_Book_Click);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox ptb_delete;
        private System.Windows.Forms.PictureBox ptb_img;
        private System.Windows.Forms.PictureBox ptb_edit;
    }
}

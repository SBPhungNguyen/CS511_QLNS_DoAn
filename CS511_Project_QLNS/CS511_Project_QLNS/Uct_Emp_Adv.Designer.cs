namespace CS511_Project_QLNS
{
    partial class Uct_Emp_Adv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uct_Emp_Adv));
            this.ptb_smallimg2 = new System.Windows.Forms.PictureBox();
            this.ptb_smallimg1 = new System.Windows.Forms.PictureBox();
            this.ptb_bigimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_smallimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_smallimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_bigimg)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_smallimg2
            // 
            this.ptb_smallimg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_smallimg2.BackgroundImage")));
            this.ptb_smallimg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_smallimg2.Location = new System.Drawing.Point(1144, 178);
            this.ptb_smallimg2.Name = "ptb_smallimg2";
            this.ptb_smallimg2.Size = new System.Drawing.Size(503, 170);
            this.ptb_smallimg2.TabIndex = 5;
            this.ptb_smallimg2.TabStop = false;
            this.ptb_smallimg2.Click += new System.EventHandler(this.ptb_smallimg2_Click);
            // 
            // ptb_smallimg1
            // 
            this.ptb_smallimg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_smallimg1.BackgroundImage")));
            this.ptb_smallimg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_smallimg1.Location = new System.Drawing.Point(1144, 2);
            this.ptb_smallimg1.Name = "ptb_smallimg1";
            this.ptb_smallimg1.Size = new System.Drawing.Size(503, 170);
            this.ptb_smallimg1.TabIndex = 4;
            this.ptb_smallimg1.TabStop = false;
            this.ptb_smallimg1.Click += new System.EventHandler(this.ptb_smallimg1_Click);
            // 
            // ptb_bigimg
            // 
            this.ptb_bigimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_bigimg.BackgroundImage")));
            this.ptb_bigimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_bigimg.Location = new System.Drawing.Point(1, 2);
            this.ptb_bigimg.Name = "ptb_bigimg";
            this.ptb_bigimg.Size = new System.Drawing.Size(1138, 346);
            this.ptb_bigimg.TabIndex = 3;
            this.ptb_bigimg.TabStop = false;
            this.ptb_bigimg.Click += new System.EventHandler(this.ptb_bigimg_Click);
            // 
            // Uct_Emp_Adv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptb_smallimg2);
            this.Controls.Add(this.ptb_smallimg1);
            this.Controls.Add(this.ptb_bigimg);
            this.Name = "Uct_Emp_Adv";
            this.Size = new System.Drawing.Size(1650, 350);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_smallimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_smallimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_bigimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_smallimg2;
        private System.Windows.Forms.PictureBox ptb_smallimg1;
        private System.Windows.Forms.PictureBox ptb_bigimg;
    }
}

namespace CS511_Project_QLNS
{
    partial class Uct_Cus_Chat
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
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.ptb_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(67, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Guest";
            // 
            // rtb_text
            // 
            this.rtb_text.Location = new System.Drawing.Point(70, 34);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.ReadOnly = true;
            this.rtb_text.Size = new System.Drawing.Size(799, 65);
            this.rtb_text.TabIndex = 2;
            this.rtb_text.Text = "";
            // 
            // ptb_img
            // 
            this.ptb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_img.Location = new System.Drawing.Point(1, 9);
            this.ptb_img.Name = "ptb_img";
            this.ptb_img.Size = new System.Drawing.Size(50, 50);
            this.ptb_img.TabIndex = 0;
            this.ptb_img.TabStop = false;
            // 
            // Uct_Cus_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtb_text);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.ptb_img);
            this.Name = "Uct_Cus_Chat";
            this.Size = new System.Drawing.Size(898, 108);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_img;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.RichTextBox rtb_text;
    }
}

namespace CS511_Project_QLNS
{
    partial class Uct_Customer_Chat
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
            this.fpnl_chat = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_text = new CS511_Project_QLNS.Uct_textbox();
            this.label1 = new System.Windows.Forms.Label();
            this.customPictureBox1 = new CS511_Project_QLNS.View.CustomPictureBox();
            this.ptb_send = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnl_chat
            // 
            this.fpnl_chat.Location = new System.Drawing.Point(0, 99);
            this.fpnl_chat.Name = "fpnl_chat";
            this.fpnl_chat.Size = new System.Drawing.Size(965, 497);
            this.fpnl_chat.TabIndex = 0;
            // 
            // txt_text
            // 
            this.txt_text.BackColor = System.Drawing.SystemColors.Window;
            this.txt_text.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_text.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_text.BorderSize = 2;
            this.txt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_text.ForeColor = System.Drawing.Color.Black;
            this.txt_text.Location = new System.Drawing.Point(0, 615);
            this.txt_text.Margin = new System.Windows.Forms.Padding(4);
            this.txt_text.Multiline = false;
            this.txt_text.Name = "txt_text";
            this.txt_text.Padding = new System.Windows.Forms.Padding(7);
            this.txt_text.PasswordChar = false;
            this.txt_text.Size = new System.Drawing.Size(922, 35);
            this.txt_text.TabIndex = 9;
            this.txt_text.Texts = "";
            this.txt_text.UnderlineStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Book Store";
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.bookstore;
            this.customPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPictureBox1.Border = 1;
            this.customPictureBox1.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox1.BorderStyle1 = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.customPictureBox1.ColorBorder = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.ColorBorder2 = System.Drawing.Color.HotPink;
            this.customPictureBox1.Gradiant = 50F;
            this.customPictureBox1.Location = new System.Drawing.Point(4, 3);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(85, 75);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 13;
            this.customPictureBox1.TabStop = false;
            // 
            // ptb_send
            // 
            this.ptb_send.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_send;
            this.ptb_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_send.Location = new System.Drawing.Point(929, 615);
            this.ptb_send.Name = "ptb_send";
            this.ptb_send.Size = new System.Drawing.Size(35, 35);
            this.ptb_send.TabIndex = 11;
            this.ptb_send.TabStop = false;
            this.ptb_send.Click += new System.EventHandler(this.ptb_send_Click);
            // 
            // Uct_Customer_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_send);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.fpnl_chat);
            this.Name = "Uct_Customer_Chat";
            this.Size = new System.Drawing.Size(980, 675);
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnl_chat;
        private System.Windows.Forms.PictureBox ptb_send;
        private Uct_textbox txt_text;
        private System.Windows.Forms.Label label1;
        private View.CustomPictureBox customPictureBox1;
    }
}

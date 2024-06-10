namespace CS511_Project_QLNS
{
    partial class Uct_Employee_Chat
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
            this.ptb_send = new System.Windows.Forms.PictureBox();
            this.txt_text = new CS511_Project_QLNS.Uct_textbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPictureBox1 = new CS511_Project_QLNS.View.CustomPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fpnl_chat = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_send
            // 
            this.ptb_send.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_send;
            this.ptb_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_send.Location = new System.Drawing.Point(1689, 874);
            this.ptb_send.Name = "ptb_send";
            this.ptb_send.Size = new System.Drawing.Size(40, 40);
            this.ptb_send.TabIndex = 8;
            this.ptb_send.TabStop = false;
            this.ptb_send.Click += new System.EventHandler(this.ptb_send_Click);
            // 
            // txt_text
            // 
            this.txt_text.BackColor = System.Drawing.SystemColors.Window;
            this.txt_text.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_text.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_text.BorderSize = 2;
            this.txt_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_text.ForeColor = System.Drawing.Color.Black;
            this.txt_text.Location = new System.Drawing.Point(8, 875);
            this.txt_text.Margin = new System.Windows.Forms.Padding(4);
            this.txt_text.Multiline = false;
            this.txt_text.Name = "txt_text";
            this.txt_text.Padding = new System.Windows.Forms.Padding(7);
            this.txt_text.PasswordChar = false;
            this.txt_text.Size = new System.Drawing.Size(1666, 39);
            this.txt_text.TabIndex = 6;
            this.txt_text.Texts = "";
            this.txt_text.UnderlineStyle = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.fpnl_chat);
            this.panel1.Controls.Add(this.customPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1724, 806);
            this.panel1.TabIndex = 15;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackgroundImage = global::CS511_Project_QLNS.Properties.Resources.icon_user2;
            this.customPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPictureBox1.Border = 1;
            this.customPictureBox1.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.customPictureBox1.BorderStyle1 = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.customPictureBox1.ColorBorder = System.Drawing.Color.RoyalBlue;
            this.customPictureBox1.ColorBorder2 = System.Drawing.Color.HotPink;
            this.customPictureBox1.Gradiant = 50F;
            this.customPictureBox1.Location = new System.Drawing.Point(3, 7);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(85, 75);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 15;
            this.customPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Guest";
            // 
            // fpnl_chat
            // 
            this.fpnl_chat.BackColor = System.Drawing.Color.White;
            this.fpnl_chat.Location = new System.Drawing.Point(3, 95);
            this.fpnl_chat.Name = "fpnl_chat";
            this.fpnl_chat.Size = new System.Drawing.Size(1718, 708);
            this.fpnl_chat.TabIndex = 16;
            // 
            // Uct_Employee_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_send);
            this.Controls.Add(this.txt_text);
            this.Name = "Uct_Employee_Chat";
            this.Size = new System.Drawing.Size(1740, 930);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_send;
        private Uct_textbox txt_text;
        private System.Windows.Forms.Panel panel1;
        private View.CustomPictureBox customPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fpnl_chat;
    }
}

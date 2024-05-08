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
            this.ptb_video = new System.Windows.Forms.PictureBox();
            this.ptb_pic = new System.Windows.Forms.PictureBox();
            this.ptb_send = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_video)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnl_chat
            // 
            this.fpnl_chat.Location = new System.Drawing.Point(0, 62);
            this.fpnl_chat.Name = "fpnl_chat";
            this.fpnl_chat.Size = new System.Drawing.Size(965, 534);
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
            this.txt_text.Location = new System.Drawing.Point(107, 615);
            this.txt_text.Margin = new System.Windows.Forms.Padding(4);
            this.txt_text.Multiline = false;
            this.txt_text.Name = "txt_text";
            this.txt_text.Padding = new System.Windows.Forms.Padding(7);
            this.txt_text.PasswordChar = false;
            this.txt_text.Size = new System.Drawing.Size(799, 35);
            this.txt_text.TabIndex = 1;
            this.txt_text.Texts = "";
            this.txt_text.UnderlineStyle = false;
            // 
            // ptb_video
            // 
            this.ptb_video.Location = new System.Drawing.Point(0, 615);
            this.ptb_video.Name = "ptb_video";
            this.ptb_video.Size = new System.Drawing.Size(35, 35);
            this.ptb_video.TabIndex = 2;
            this.ptb_video.TabStop = false;
            // 
            // ptb_pic
            // 
            this.ptb_pic.Location = new System.Drawing.Point(50, 615);
            this.ptb_pic.Name = "ptb_pic";
            this.ptb_pic.Size = new System.Drawing.Size(35, 35);
            this.ptb_pic.TabIndex = 3;
            this.ptb_pic.TabStop = false;
            // 
            // ptb_send
            // 
            this.ptb_send.Location = new System.Drawing.Point(930, 615);
            this.ptb_send.Name = "ptb_send";
            this.ptb_send.Size = new System.Drawing.Size(35, 35);
            this.ptb_send.TabIndex = 4;
            this.ptb_send.TabStop = false;
            // 
            // Uct_Customer_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptb_send);
            this.Controls.Add(this.ptb_pic);
            this.Controls.Add(this.ptb_video);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.fpnl_chat);
            this.Name = "Uct_Customer_Chat";
            this.Size = new System.Drawing.Size(980, 675);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_video)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnl_chat;
        private Uct_textbox txt_text;
        private System.Windows.Forms.PictureBox ptb_video;
        private System.Windows.Forms.PictureBox ptb_pic;
        private System.Windows.Forms.PictureBox ptb_send;
    }
}

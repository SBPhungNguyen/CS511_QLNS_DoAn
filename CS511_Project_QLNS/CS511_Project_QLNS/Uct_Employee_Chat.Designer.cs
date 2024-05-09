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
            this.fpnl_chat = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_send
            // 
            this.ptb_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_send.Location = new System.Drawing.Point(930, 616);
            this.ptb_send.Name = "ptb_send";
            this.ptb_send.Size = new System.Drawing.Size(35, 35);
            this.ptb_send.TabIndex = 8;
            this.ptb_send.TabStop = false;
            // 
            // txt_text
            // 
            this.txt_text.BackColor = System.Drawing.SystemColors.Window;
            this.txt_text.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txt_text.BorderFocusColor = System.Drawing.Color.Green;
            this.txt_text.BorderSize = 2;
            this.txt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_text.ForeColor = System.Drawing.Color.Black;
            this.txt_text.Location = new System.Drawing.Point(1, 616);
            this.txt_text.Margin = new System.Windows.Forms.Padding(4);
            this.txt_text.Multiline = false;
            this.txt_text.Name = "txt_text";
            this.txt_text.Padding = new System.Windows.Forms.Padding(7);
            this.txt_text.PasswordChar = false;
            this.txt_text.Size = new System.Drawing.Size(922, 35);
            this.txt_text.TabIndex = 6;
            this.txt_text.Texts = "";
            this.txt_text.UnderlineStyle = false;
            // 
            // fpnl_chat
            // 
            this.fpnl_chat.Location = new System.Drawing.Point(0, 62);
            this.fpnl_chat.Name = "fpnl_chat";
            this.fpnl_chat.Size = new System.Drawing.Size(965, 534);
            this.fpnl_chat.TabIndex = 5;
            // 
            // Uct_Employee_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ptb_send);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.fpnl_chat);
            this.Name = "Uct_Employee_Chat";
            this.Size = new System.Drawing.Size(980, 675);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_send)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_send;
        private Uct_textbox txt_text;
        private System.Windows.Forms.FlowLayoutPanel fpnl_chat;
    }
}

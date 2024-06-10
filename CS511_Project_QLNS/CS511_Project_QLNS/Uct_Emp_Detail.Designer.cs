namespace CS511_Project_QLNS
{
    partial class Uct_Emp_Detail
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.customPanel1.BorderColor = System.Drawing.Color.White;
            this.customPanel1.Controls.Add(this.lbl_id);
            this.customPanel1.Controls.Add(this.lbl_title);
            this.customPanel1.Controls.Add(this.lbl_price);
            this.customPanel1.Controls.Add(this.lbl_quantity);
            this.customPanel1.Controls.Add(this.lbl_sum);
            this.customPanel1.Location = new System.Drawing.Point(0, 4);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Radius = 20;
            this.customPanel1.Size = new System.Drawing.Size(1877, 100);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.Thickness = 0F;
            // 
            // lbl_id
            // 
            this.lbl_id.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lbl_id.Location = new System.Drawing.Point(23, 32);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(165, 39);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "id";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lbl_title.Location = new System.Drawing.Point(309, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(537, 82);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Name";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lbl_price.Location = new System.Drawing.Point(965, 38);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(201, 39);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = "Price";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lbl_quantity.Location = new System.Drawing.Point(1314, 38);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(175, 39);
            this.lbl_quantity.TabIndex = 6;
            this.lbl_quantity.Text = "Quantity";
            this.lbl_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sum
            // 
            this.lbl_sum.Font = new System.Drawing.Font("Arial", 16.2F);
            this.lbl_sum.Location = new System.Drawing.Point(1640, 38);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(173, 39);
            this.lbl_sum.TabIndex = 6;
            this.lbl_sum.Text = "Sum";
            this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Uct_Emp_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel1);
            this.Name = "Uct_Emp_Detail";
            this.Size = new System.Drawing.Size(1880, 110);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private View.CustomPanel customPanel1;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_title;
    }
}

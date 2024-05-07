using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS511_Project_QLNS.View
{
    public class CustomPictureBox : PictureBox
    {
        private int border = 2;
        private Color colorBorder = Color.RoyalBlue;
        private Color colorBorder2 = Color.HotPink;
        private DashStyle borderStyle = DashStyle.Solid;
        private DashCap borderCap = DashCap.Flat;
        private float gradiant = 50;

        public CustomPictureBox()
        {
            this.Size = new Size(95, 95);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int Border
        {
            get => border;
            set
            {
                border = value;
                this.Invalidate();
            }
        }
        public Color ColorBorder
        {
            get => colorBorder;
            set
            {
                colorBorder = value;
                this.Invalidate(true);
            }
        }
        public Color ColorBorder2
        {
            get => colorBorder2;
            set
            {
                colorBorder2 = value;
                this.Invalidate();
            }
        }
        public DashStyle BorderStyle1
        {
            get => borderStyle;
            set
            {
                borderStyle = value;
                this.Invalidate(true);
            }
        }
        public DashCap BorderCap
        {
            get => borderCap;
            set
            {
                borderCap = value;
                this.Invalidate();
            }
        }
        public float Gradiant
        {
            get => gradiant;
            set
            {
                gradiant = value;
                this.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Height);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics graphic = pe.Graphics;
            Rectangle rect = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            Rectangle recborder = Rectangle.Inflate(rect, -border, -border);
            var size = border > 0 ? border * 3 : 1;

            using (var bordercolorG = new LinearGradientBrush(recborder, colorBorder, colorBorder2, gradiant))
            using (var path = new GraphicsPath())
            using (var pen = new Pen(this.Parent.BackColor, border))
            using (var penborder = new Pen(bordercolorG, size))
            {
                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                penborder.DashStyle = borderStyle;
                penborder.DashCap = borderCap;

                path.AddEllipse(rect);

                this.Region = new Region(path);

                graphic.DrawEllipse(pen, rect);
                if (border > 0)
                {
                    graphic.DrawEllipse(penborder, recborder);
                }
            }
        }
    }
}

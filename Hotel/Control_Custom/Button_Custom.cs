using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hotel
{
    class Button_Custom : Button
    {
        public Button_Custom():base()
        {
            this.BackColor = Color.Crimson;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );
        private int radius = 50;
        private Color _borderColor = Color.Black;
        private Color _buttonColor =SystemColors.Control;
        private float _borderSize = 1.75f;
        
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));

            }
        }
        private GraphicsPath GetRoundPath(RectangleF Rect,float m)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X+m, Rect.Y+m, radius, radius, 180, 90);

            GraphPath.AddArc(Rect.X+Rect.Width - radius - m, Rect.Y +m, radius, radius, 270, 90);
            GraphPath.AddArc(Rect.X+Rect.Width - radius - m,
                           Rect.Y+Rect.Height - radius - m, radius, radius, 0, 90);
            GraphPath.AddArc(Rect.X+m , Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            

            RectangleF Rect = new RectangleF(2, 2, this.Width-4, this.Height-4);
            GraphicsPath GraphPath = GetRoundPath(Rect,0);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));
            Pen pen = new Pen(BorderColor, BorderSize);
            pen.Alignment = PenAlignment.Center;
            pen.Brush = new SolidBrush(ButtonColor);
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            base.OnPaint(e);
            

        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

       

        public float BorderSize { get => _borderSize; set { _borderSize = value; Invalidate(); } }

        public Color ButtonColor { get => _buttonColor; set { _buttonColor = value; Invalidate(); } }
    }
}

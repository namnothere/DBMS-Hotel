using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Hotel
{
    class Panel_Custom:Panel
    {

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
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));

            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));
            base.OnPaint(e);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_and_2
{
    class CCircle : Shape
    {
        //public override void Draw(Bitmap bitmap, Point[] points)
        public override void Draw(Bitmap bitmap)
        {
            base.Draw(bitmap);
            Rectangle rectangle = new Rectangle(base.Coords[0].X, base.Coords[0].Y, Math.Min(base.Coords[1].X - base.Coords[0].X, base.Coords[1].Y - base.Coords[0].Y), Math.Min(base.Coords[1].X - base.Coords[0].X, base.Coords[1].Y - base.Coords[0].Y));
            paint.DrawEllipse(pen, rectangle);
        }
    }
}

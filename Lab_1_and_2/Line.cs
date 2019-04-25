using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_and_2
{
    class CLine : Shape
    {
        //public override void Draw(Bitmap bitmap, Point[] points)
        public override void Draw(Bitmap bitmap)
        {
            //base.Draw(bitmap, points);
            base.Draw(bitmap);
            paint.DrawLine(pen, base.Coords[0].X, base.Coords[0].Y, base.Coords[1].X, base.Coords[1].Y);
        }
    }
}

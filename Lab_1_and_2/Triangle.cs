using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_and_2
{
    class CTriangle : Shape
    {
        //public override void Draw(Bitmap bitmap, Point[] points)
        public override void Draw(Bitmap bitmap)
        {
            base.Draw(bitmap);
            paint.DrawPolygon(pen, base.Coords);
        }
    }
}

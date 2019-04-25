using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_and_2
{
    class CRectangle : Shape
    {
        public Point[] SwapCoordinates(Point[] points, byte coordinate)//0-X; 1-Y
        {
            if (coordinate == 0)
            {
                int temp;
                temp = points[0].X;
                points[0].X = points[1].X;
                points[1].X = temp;

            }
            else
            {

                int temp;
                temp = points[0].Y;
                points[0].Y = points[1].Y;
                points[1].Y = temp;

            }

            return points;

        }

        //public override void Draw(Bitmap bitmap, Point[] points)
        public override void Draw(Bitmap bitmap)
        {
            base.Draw(bitmap);
            Boolean changedX = false, changedY = false;
            if (base.Coords[0].Y > base.Coords[1].Y)
            {
                changedY = true;
                base.Coords = SwapCoordinates(base.Coords, 1);
            }
            if (base.Coords[0].X > base.Coords[1].X)
            {
                changedX = true;
                base.Coords = SwapCoordinates(base.Coords, 0);
            }


            Rectangle rectangle = new Rectangle(base.Coords[0].X, base.Coords[0].Y, base.Coords[1].X - base.Coords[0].X, base.Coords[1].Y - base.Coords[0].Y);
            paint.DrawRectangle(pen, rectangle);
            if (changedX)
            {
                SwapCoordinates(base.Coords, 0);
            }
            if (changedY)
            {
                SwapCoordinates(base.Coords, 1);
            }
        }
    }
}

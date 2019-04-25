using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_and_2
{
    class CSquare : Shape
    {
        //public override void Draw(Bitmap bitmap, Point[] points)
        public override void Draw(Bitmap bitmap)
        {
            base.Draw(bitmap);

            CRectangle myRectangle = new CRectangle();
            Boolean changedX = false, changedY = false;

            if (base.Coords[0].Y > base.Coords[1].Y)
            {
                changedY = true;
                base.Coords = myRectangle.SwapCoordinates(base.Coords, 1);
            }

            if (base.Coords[0].X > base.Coords[1].X)
            {
                changedX = true;
                base.Coords = myRectangle.SwapCoordinates(base.Coords, 0);
            }

            int height;

            height = Math.Min(base.Coords[1].X - base.Coords[0].X, base.Coords[1].Y - base.Coords[0].Y);

            if (changedX)
            {
                myRectangle.SwapCoordinates(base.Coords, 0);
            }
            if (changedY)
            {
                myRectangle.SwapCoordinates(base.Coords, 1);
            }
            Rectangle rectangle = new Rectangle();

            if (changedX && changedY)
            {
                rectangle = new Rectangle(base.Coords[0].X - height, base.Coords[0].Y - height, height, height);
            }
            else
            {
                if (changedX)
                {
                    rectangle = new Rectangle(base.Coords[0].X - height, base.Coords[0].Y, height, height);
                }
                else
                {
                    if (changedY)
                    {
                        rectangle = new Rectangle(base.Coords[0].X, base.Coords[0].Y - height, height, height);
                    }
                    else
                    {
                        rectangle = new Rectangle(base.Coords[0].X, base.Coords[0].Y, height, height);
                    }
                }
            }
            paint.DrawRectangle(pen, rectangle);
        }
    }
}

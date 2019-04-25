using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab_1_and_2
{
    class Shape
    {
        public static Graphics paint;
        public Pen pen;
        private Point[] points;
        public Point[] Coords
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }

        //public virtual void Draw(Bitmap bitmap, Point[] points)
        public virtual void Draw(Bitmap bitmap)
        {
            paint = Graphics.FromImage(bitmap);
            pen = new Pen(Form_Editor.brushColor);
            pen.Width = Form_Editor.penWidth;
        }
    }
}

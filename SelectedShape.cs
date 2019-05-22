using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    class SelectedShape
    {
        private static SelectedShape instance;
        private static bool Selected = false;

        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public Pen P;

        public SelectedShape(int X1, int Y1, int X2, int Y2, Pen RecP)
        {
            W = Math.Abs(X1 - X2);
            H = Math.Abs(Y1 - Y2);
            X = Math.Min(X1, X2);
            Y = Math.Min(Y1, Y2);
            P = RecP;
            Selected = true;
        }

        public static void SetSel(int X1, int Y1, int X2, int Y2, Pen RecP)
        {
            if (instance == null)
            {
                instance = new SelectedShape(X1, Y1, X2, Y2, RecP);
            }
            else
            {
                instance.X = Math.Min(X1, X2);
                instance.Y = Math.Min(Y1, Y2);
                instance.H = Math.Abs(Y1 - Y2);
                instance.W = Math.Abs(X1 - X2);
                instance.P = RecP;
            }
            Selected = true;
        }

        public static bool IsSelected()
        {
            return Selected;
        }

        public static int GetX()
        {
            return instance.X;
        }

        public static int GetY()
        {
            return instance.Y;
        }

        public static int GetW()
        {
            return instance.W;
        }

        public static int GetH()
        {
            return instance.H;
        }

        public static Pen GetP()
        {
            return instance.P;
        }

        public static void SetFalse()
        {
            Selected = false;
        }
    }
}

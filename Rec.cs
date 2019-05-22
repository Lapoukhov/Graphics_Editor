using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    [Serializable]
    class Rec:Shape, ISelectable, IEditable
    {
        public Rec(int X1, int Y1, int X2, int Y2, Pen P)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
            this.PW = (int)P.Width;
            this.PC = P.Color.ToArgb();
            //this.P = P;
        }

        public Rec()
        {

        }

        public override void Draw(Graphics g)
        {
            int w = Math.Abs(X1 - X2);
            int h = Math.Abs(Y1 - Y2);
            int X = Math.Min(X1, X2);
            int Y = Math.Min(Y1, Y2);


            Pen P = new Pen(Color.FromArgb(PC));
            P.Width = PW;

            g.DrawRectangle(P, X, Y, w, h);
        }
    }
}

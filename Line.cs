using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    [Serializable]
    class Line:Shape, ISelectable, IEditable
    {
        public Line(int X1, int Y1, int X2, int Y2, Pen P)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
            this.PW = (int)P.Width;
            this.PC = P.Color.ToArgb();
        }

        public Line()
        {
        }

        public override void Draw(Graphics g)
        {
            Pen P = new Pen(Color.FromArgb(PC));
            P.Width = PW;
            g.DrawLine(P, X1, Y1, X2, Y2);
        }
    }
}

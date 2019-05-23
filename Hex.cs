using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    [Serializable]
    class Hex:Shape, ISelectable, IEditable
    {
        public Hex(int X1, int Y1, int X2, int Y2, Pen P)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
            this.PW = (int)P.Width;
            this.PC = P.Color.ToArgb();
        }

        public Hex()
        {
        }

        public override void Draw(Graphics g)
        {
            int AX = Math.Min(X1, X2);
            int AY = Math.Min(Y1, Y2);
            int BX = Math.Max(X1, X2);
            int BY = Math.Max(Y1, Y2);
            int w = Math.Abs(X1 - X2) / 3;
            int h = Math.Abs(Y1 - Y2) / 2;

            Pen P = new Pen(Color.FromArgb(PC));
            P.Width = PW;

            g.DrawLine(P, AX, AY + h, AX + w, AY);
            g.DrawLine(P, AX + w, AY, AX + 2 * w, AY);
            g.DrawLine(P, AX + 2 * w, AY, BX, AY + h);
            g.DrawLine(P, BX, AY + h, BX - w, BY);
            g.DrawLine(P, BX - w, BY, BX - 2 * w, BY);
            g.DrawLine(P, BX - 2 * w, BY, AX, AY + h);
        }
    }
}

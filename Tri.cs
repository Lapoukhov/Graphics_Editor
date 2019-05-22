using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    [Serializable]
    class Tri:Shape, ISelectable, IEditable
    {
        public Tri(int X1, int Y1, int X2, int Y2, Pen P)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
            this.PW = (int)P.Width;
            this.PC = P.Color.ToArgb();
            //this.P = P;
        }

        public Tri()
        {

        }

        public override void Draw(Graphics g)
        {
            int AX = Math.Min(X1, X2);
            int AY = Math.Min(Y1, Y2);
            int BX = Math.Max(X1, X2);
            int BY = Math.Max(Y1, Y2);
            int CX = BX;
            int CY = AY;


            Pen P = new Pen(Color.FromArgb(PC));
            P.Width = PW;

            g.DrawLine(P, AX, AY, BX, BY);
            g.DrawLine(P, BX, BY, CX, CY);
            g.DrawLine(P, CX, CY, AX, AY);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    class OctCreator : Creator
    {
        public override Shape Create(int X1, int Y1, int X2, int Y2, Pen P)
        {
            return new Oct(X1, Y1, X2, Y2, P);
        }
    }
}

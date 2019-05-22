using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    abstract class Creator
    {
        public abstract Shape Create(int X1, int Y1, int X2, int Y2, Pen P);
    }
}

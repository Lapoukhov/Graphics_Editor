﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    class ElpCreator : Creator
    {
        public override Shape Create(int X1, int Y1, int X2, int Y2, Pen P)
        {
            return new Elp(X1, Y1, X2, Y2, P);
        }
    }
}
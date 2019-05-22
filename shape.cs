using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace _1laba
{
    [Serializable]
    [DataContract]
    public abstract class Shape
    {
        [DataMember]
        public int X1 { get; set; }
        [DataMember]
        public int Y1 { get; set; }
        [DataMember]
        public int X2 { get; set; }
        [DataMember]
        public int Y2 { get; set; }
        [DataMember]
        public int PW { get; set; }
        [DataMember]
        public int PC { get; set; }
        //public Pen P;
        //        public int Pwidth { get; set; }
        //        public Color Pcolor { get; set; }

        public abstract void Draw(Graphics g);
    }
}

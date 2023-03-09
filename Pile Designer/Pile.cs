using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Point = System.Drawing.Point;

namespace Pile_Designer
{
    internal class Pile : ReactionPoint
    {
        public Pile(float x, float y, string name) : base(x,y,new Load(0,0,"kN"))
        {
            this.name = name;
        }

        public string name;
        public int capacity = 100;

        // returns a rounded integer of the piles location
        // (actual values are floats)
        public Point getIntPoint()
        {
            return new Point((int)x,(int)y);
        }

        // return its reaction and capacity
        public override string ToString()
        {
            return "Reaction = " + reaction.sls + "kN (SLS)\n" + // piles sls only
                                    "Capacity = " + capacity + "kN (SLS)\n\n";
        }
    }
}
}

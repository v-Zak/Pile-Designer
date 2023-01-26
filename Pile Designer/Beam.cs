using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class Beam
    {

        public Beam(Pile p1, Pile p2, float W) 
        { 
        this.p1 = p1;
        this.p2 = p2;
        this.W = W;
        }

        public Pile p1;
        public Pile p2;
        public float W;
    }
}

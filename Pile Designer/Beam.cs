using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class Beam
    {

        public Beam(int p1, int p2, float W) 
        { 
        this.p1 = p1;
        this.p2 = p2;
        this.W = W;
        }

        public void calcBM()
        {
            BM = (W * span) / 8;
        }

        public int p1;
        public int p2;
        public float span;
        public float W;
        public float BM;
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class Beam
    {

        public Beam(int p1, int p2, int ll, string name) 
        {
        this.name = name;
        this.p1 = p1;
        this.p2 = p2;
        this.ll = ll;
        }

        public void calcBM()
        {
            BM = (W.uls * span) / 8;
        }
        public string name;
        public int p1; // reference to pile
        public int p2; // reference to pile
        public float span;
        public int ll; // reference to line load
        public Load W;
        public Load R;
        public float BM; // bm is uls only
    }
}

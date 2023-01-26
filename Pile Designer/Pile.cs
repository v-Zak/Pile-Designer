using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class Pile
    {
        public Pile(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public int x = 0;
        public int y = 0;
        public float reaction = 0;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class LineLoad
    {
        public LineLoad(string name, float w)
        {
            this.name = name;
            this.w = w;
        }

        public string name;
        public float w;
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class LineLoad
    {
        public LineLoad(string name, Load w)
        {
            this.name = name;
            this.w = w;
        }

        public LineLoad(string name, float sls, float uls, string unit = "kN/m")
        {
            this.name = name;
            this.w = new Load(sls,uls,unit);
        }

        public string name;
        public Load w;
    }
}

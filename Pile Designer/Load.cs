using Microsoft.Office.Interop.Word;
using Pile_Designer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pile_Designer
{
    internal class Load
    {
        public Load(float sls, float uls, string units = "Default")
        {
            this.sls = sls;
            this.uls = uls;
            this.units = units;
        }

        public Load(Load prev)
        {
            this.sls = prev.sls;
            this.uls = prev.uls;
            this.units = prev.units;
        }

        public string units;
        public float sls;
        public float uls;

        // operators
        // (units have to be manually updated after A x B or A / B
        public static Load operator -(Load a)
        => new Load(-a.sls, -a.uls, a.units);

        public static Load operator +(Load a, Load b)
        => new Load(a.sls + b.sls, a.uls + b.uls, a.units);

        public static Load operator -(Load a, Load b)
        => new Load(a.sls - b.sls, a.uls - b.uls, a.units);

        public static Load operator *(Load a, int b)
        => new Load(a.sls * b, a.uls * b, a.units);

        public static Load operator *(Load a, float b)
        => new Load(a.sls * b, a.uls * b);

        public static Load operator *(int a, Load b)
        => b * a;

        public static Load operator *(float a, Load b)
        => b * a;

        public static Load operator /(Load a, float b)
        {
           if (b == 0) throw new DivideByZeroException();

           return new Load(a.sls / b, a.uls / b);

        }

        public override string ToString() => $"{Math.Round(sls,2)}{units} (SLS) / {Math.Round(uls,2)}{units} (ULS)";
    }    
}



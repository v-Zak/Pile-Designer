using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class ReactionPoint
    {
        public ReactionPoint(float x, float y, Load reaction) {
            this.x = x;
            this.y = y;
            this.reaction = reaction;        
        }

        public float x, y;
        public Load reaction;
    }
}

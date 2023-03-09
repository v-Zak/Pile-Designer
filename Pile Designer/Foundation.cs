using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class Foundation
    {
        public Foundation()
        {

        }

        List<Pile> piles = new List<Pile>();
        List<Beam> beams = new List<Beam>();

        public void addPile(float x, float y, string name)
        {
            Pile p = new Pile(x, y, name);
            piles.Add(p);
        }

        public void addBeam(ReactionPoint p1, ReactionPoint p2, Load ll, string name, List<ReactionPoint> pls)
        {
            Beam b = new Beam(p1, p2, ll, name, pls);
            beams.Add(b);
        }
       
        public void clearPiles()
        {
            piles.Clear();
        }

        public void clearBeams()
        {
            beams.Clear();
        }

        public void update()
        {

        }

        private void updateBeams()
        {

        }
        private void updatePiles()
        {

        }
    }
}

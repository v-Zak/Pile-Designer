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

        public Beam(ReactionPoint p1, ReactionPoint p2, Load ll, string name, List<ReactionPoint> pls) 
        {
        this.name = name;
        this.p1 = p1;
        this.p2 = p2;
        this.ll = ll;
        this.pls = pls;       
        }

        public void update()
        {
            zeroReactions();
            calcSpan();
            calcPLDistances();
            calcReactions();
            calcBM();
        }

        public void zeroReactions()
        {
            p1.reaction = new Load(0, 0, "kN");
            p2.reaction = new Load(0, 0, "kN");
        }

        public void calcSpan()
        {
            span = getDistance(p1.x, p1.y, p2.x, p2.y);
        }

        // gets distance between 2 points
        private float getDistance(float p1X, float p1Y, float p2X, float p2Y)
        {
            float dx = p2X - p1X;
            float dy = p2Y - p1Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private void calcPLDistances() // relative to p1
        {
            foreach(var p in this.pls)
            {
                distancesToP1.Add(getDistance(p1.x, p1.y, p.x, p.y));
            }
        }

        private void calcReactions()
        {
            W = ll * span;
            p1.reaction = W / 2;
            p2.reaction = W / 2;

            for (int i = 0; i < pls.Count; i++)
            {
                var pl = pls[i];
                var dist = distancesToP1[i];

                p1.reaction += pl.reaction * dist / span;
                p2.reaction += pl.reaction * (span - dist) / span;
            }            
        }

        private void calcBM()
        {
            // line laod 
            bm += (W.uls * span) / 8;

            // add pl's
            for (int i = 0; i < pls.Count; i++)
            {
                var pl = pls[i];
                var dist = distancesToP1[i];
                bm += (pl.reaction.uls * dist * (span - dist)) / span;
            }
        }

        public void calcReaction()
        {

        }

        public string name;
        public ReactionPoint p1;
        public ReactionPoint p2; 
        public float span;
        public Load ll; // little w
        public Load W; // big W
        public Load r;
        public float bm; // bm is uls only
        public List<ReactionPoint> pls; // point loads from other reactions
        public List<float> distancesToP1; // point load distances
    }
}

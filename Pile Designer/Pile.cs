using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pile_Designer
{
    internal class Pile
    {
        public Pile(float x, float y, string name)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.reaction = 0;
        }

        public string name;
        public float x = 0;
        public float y = 0;

        private float _reaction;
        public float reaction
        {
            set { 
                this._reaction = value; 
                this.capacity = Math.Max((int)(value / 25) * 25 + 25, 100);
            }
            get { return this._reaction; }
        }
        public int capacity = 0;

        // returns a rounded integer of the piles location
        // (actual values are floats)
        public Point getPoint()
        {
            return new Point((int)x,(int)y);
        }
    }
}

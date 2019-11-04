using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librairie
{
    public class Cercle : Forme
    {
        private int rayon;

        public Cercle() : base()
        {

        }
        public Cercle(int i ,int r, int y, int x) : base(i, x, y, "Cercle")
        {
            this.rayon = r;
        }
        public Cercle(int r, int y, int x) : base(x, y,"Cercle")
        {
            this.rayon = r;
        }
        public Cercle(int r, int y, int x,string NULL) : base(x, y)
        {
            this.rayon = r;
        }
        public int getR()
        {
            return this.rayon;
        }
        public override double perimetre()
        {
            double perimetre = 2 * this.rayon * Math.PI;
            return perimetre;
        }
        public override double surface()
        {
            double surface = (this.rayon*this.rayon)*Math.PI;
            return surface;
        }
    }
}

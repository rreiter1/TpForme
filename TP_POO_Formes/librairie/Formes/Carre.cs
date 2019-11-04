using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librairie
{
    public class Carre : Forme
    {
        private int Cote;

        public Carre() :base()
        {

        }
        public Carre(int i ,int c, int y, int x) : base(i, x, y, "Carre")
        {
            this.Cote = c;
        }
        public Carre(int c, int y , int x) : base(x,y,"Carre")
        {
            this.Cote = c;
        }
        public Carre(int c, int y, int x,string NULL) : base(x, y)
        {
            this.Cote = c;
        }
        public int getC()
        {
            return this.Cote;
        }
        public override double perimetre()
        {
            double perimetre = this.Cote*4;
            return perimetre;
        }
        public override double surface()
        {
            double surface = this.Cote * this.Cote;
            return surface;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librairie
{
    public class Rectangle : Forme
    {
        private int longeure;
        private int largeur;

        public Rectangle() : base()
        {

        }
        public Rectangle(int i ,int lo, int la, int y, int x) : base(i,x, y, "Rectangle")
        {
            this.longeure = lo;
            this.largeur = la;
        }
        public Rectangle(int lo,int la, int y, int x) : base(x, y,"Rectangle")
        {
            this.longeure = lo;
            this.largeur = la;
        }
        public Rectangle(int lo, int la, int y, int x,string Null) : base(x, y)
        {
            this.longeure = lo;
            this.largeur = la;
        }
        public int getlong()
        {
            return this.longeure;
        }
        public int getlarg()
        {
            return this.largeur;
        }
        public override double perimetre()
        {
            double perimetre = (this.longeure + this.largeur) * 2;
            return perimetre;
        }
        public override double surface()
        {
            double surface = this.longeure * this.largeur;
            return surface;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librairie
{
    public class Point
    {
        private int x;
        private int y;


        public Point()
        {

        }
        public Point(int posX, int posY)
        {
            this.x = posX;
            this.y = posY;
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
    }
}

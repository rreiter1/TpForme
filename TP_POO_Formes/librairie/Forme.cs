using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace librairie
{
    public abstract class Forme
    {
        private string type;
        private int id;
        private Point laPosition;
        public static int compteur = 1;

        public string Type { get => type; set => type = value; }
        public int Id { get => id; set => id = value; }

        public Forme()
        {

        }
        public Forme(int i ,int x, int y, string t)
        {
            this.Id = i;
            compteur++;
            this.laPosition = new Point(x, y);
            this.Type = t;

        }
        public Forme(int x, int y, string t)
        {
            this.Id = compteur;
            compteur++;
            this.laPosition = new Point(x, y);
            this.Type = t;

        }
        public Forme(int x , int y)
        {
            this.laPosition = new Point(x, y);
        }
        public Point getposi()
        {
            return this.laPosition;
        }
        public abstract double perimetre();
        public abstract double surface();
    }
}
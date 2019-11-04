using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librairie.DessinationForme
{
    public class DessinateurCercle : Dessinateur
    {
        public void dessiner(Forme f, Control c)
        {
            Cercle f1 = (Cercle)f;
            Graphics formGraphics;
            formGraphics = c.CreateGraphics();

            SolidBrush myBrush = new SolidBrush(Color.Blue);
            formGraphics.FillEllipse(myBrush, new System.Drawing.Rectangle(f.getposi().getY(), f.getposi().getX(), f1.getR(), f1.getR()));
            myBrush.Dispose();

        }
    }
}

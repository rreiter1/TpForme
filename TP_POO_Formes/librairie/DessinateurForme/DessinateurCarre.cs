using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librairie.DessinationForme
{
    public class DessinateurCarre : Dessinateur
    {
        public void dessiner(Forme f, Control c)
        {
            Carre f1 = (Carre)f;
            System.Drawing.Graphics formGraphics;
            formGraphics = c.CreateGraphics();

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Fuchsia);
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(f.getposi().getY(), f.getposi().getX(), f1.getC(), f1.getC()));
            myBrush.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librairie.DessinationForme
{
    public class DessinateurRectangle : Dessinateur
    {
        public void dessiner(Forme f, Control c)
        {
            Rectangle f1 = (Rectangle)f;
            System.Drawing.Graphics formGraphics;
            formGraphics = c.CreateGraphics();

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(f.getposi().getY(), f.getposi().getX(), f1.getlong(), f1.getlarg()));
            myBrush.Dispose();
        }
    }
}

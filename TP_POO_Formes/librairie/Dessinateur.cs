using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librairie
{
    public interface Dessinateur
    {
        void dessiner(Forme f, Control c);
    }
}

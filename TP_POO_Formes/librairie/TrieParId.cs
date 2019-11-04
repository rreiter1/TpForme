using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librairie
{
    public class TrieParId: IComparer<Forme>
    {
        public int Compare(Forme x,Forme y)
        {
            if (x.Id > y.Id)
            {
                return 1;
            }
            else if (x.Id < y.Id)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}

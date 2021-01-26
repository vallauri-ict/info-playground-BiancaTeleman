using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public abstract class Quadrupede:AnimaleTerrestre
    {
        public Quadrupede(string s):base(s)
        {
            
        }
        public override string si_muove()
        {
            return "avanzando su 4 zampe";
        }

    }
}

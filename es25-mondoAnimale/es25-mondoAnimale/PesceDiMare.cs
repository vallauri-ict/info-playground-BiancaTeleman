using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class PesceDiMare:AnimaleMarino
    {
        public PesceDiMare(string s):base(s)
        {

        }
        public override string si_muove()
        {
            return "nuotando";
        }
    }
}

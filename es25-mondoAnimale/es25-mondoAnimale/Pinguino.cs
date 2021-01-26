using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class Pinguino:Uccello
    {
        public Pinguino(string s):base(s)
        {
            verso = "non fa versi";
        }
        public override string si_muove()
        {
            return "ma non sa volare";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class Tonno:PesceDiMare
    {
        public Tonno(string s):base(s)
        {
            verso = "non fa versi";
        }
        public override string chi_sei()
        {
            return "un tonno";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class Cavallo:Quadrupede
    {
        public Cavallo(string s):base(s)
        {
            verso = "nistrisce";
        }
        public override string chi_sei()
        {
            return "un cavallo";
        }
        

    }
}

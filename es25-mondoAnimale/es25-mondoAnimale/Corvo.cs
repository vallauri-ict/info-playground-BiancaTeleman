using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class Corvo:Uccello
    {
        public Corvo(string s):base(s)
        {
            verso = "gracchia";
        }
        public override string chi_sei()
        {
            return "un corvo";
        }
    }
}

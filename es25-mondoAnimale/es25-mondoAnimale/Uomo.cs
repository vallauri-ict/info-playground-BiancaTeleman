using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class Uomo: Bipede
    {
        public Uomo(string s):base(s)
        {
            verso = "parla";
        }
        public override string vive()
        {
            return "in condominio";
        }
        public override string chi_sei()
        {
            return "un homo sapiens";
        }
    }
}

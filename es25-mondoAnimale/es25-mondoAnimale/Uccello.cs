using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es25_mondoAnimale
{
    public class Uccello:Animale
    {
        public Uccello(string s):base(s)
        {
            verso = "cinguetta";
        }
        public override string vive()
        {
            return "in un nido su un albero";
        }

        public override string chi_sei()
        {
            return "un uccello";
        }
        public override string si_muove()
        {
            return "volando";
        }

    }
}

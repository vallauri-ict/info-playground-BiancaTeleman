using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es23_carte2
{
    class Carte
    {
        private string valore;
        private string seme;

        public string Valore { get => valore; set => valore = value; }
        public string Seme { get => seme; set => seme = value; }

        public Carte(string valore,string seme)
        {
            Seme = seme;
            Valore = valore;
        }
    }
}

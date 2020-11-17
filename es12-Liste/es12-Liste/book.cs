using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es12_Liste
{
    public class book
    {
        public int ID;
        public string titolo;
        public string autore;

        public book(int clsTxtId,string clstxtTitolo, string clsAutore)
        {
            this.ID = clsTxtId;
            this.titolo = clstxtTitolo;
            this.autore = clsAutore;
        }
    }
}

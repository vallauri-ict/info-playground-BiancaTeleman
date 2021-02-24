using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es29_usoInterfacciaICompare
{
    class Persona
    {
        private string nome;
        private string cognome;
        private string città;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Città { get => città; set => città = value; }

        public Persona(string nome, string cognome, string città)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Città = città;
        }
        public override string ToString()
        {
            return (Cognome + " " + Nome + " " + Città);
        }

        public class ConfrontaCognome:IComparer<Object>
        {
            public int Compare(object x, object y)
            {
                if(x==null&&(y==null))
                {
                    return 0;
                }
                else if(x==null)
                {
                    return 1;
                }
                else if(y==null)
                {
                    return -1;
                }
                else
                {
                    Persona p1 = (Persona)x;
                    Persona p2 = (Persona)y;
                    return string.Compare(p1.Cognome, p2.Cognome, true);
                }
            }
        }

        public class ConfrontaNone : IComparer<Object>
        {
            public int Compare(object x, object y)
            {
                if (x == null && (y == null))
                {
                    return 0;
                }
                else if (x == null)
                {
                    return 1;
                }
                else if (y == null)
                {
                    return -1;
                }
                else
                {
                    Persona p1 = (Persona)x;
                    Persona p2 = (Persona)y;
                    return string.Compare(p1.Nome, p2.Nome, true);
                }
            }
        }
    }
}

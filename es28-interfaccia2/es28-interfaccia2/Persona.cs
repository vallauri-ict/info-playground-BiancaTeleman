using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es28_interfaccia2
{
    class Persona: IComparable
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
        public int compareTo(object obj)
        {
            if(obj==null)
            {
                return 1;
            }
            Persona p = obj as Persona;
            return String.Compare(Cognome, p.Cognome, true);
        }
        public override string ToString()
        {
            return (Cognome+" "+Nome+" "+Città);

        }
    }
}

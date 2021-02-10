using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es26_esercizioPersone
{
    class clsAlunno : clsPersona
    {
        #region attributi
        protected static int progressivo = 0;
        private readonly string matricola;
        private string classe;
        private string sezione;
        private string specializzazione;
        #endregion
        public string Classe { get => classe; set => classe = Convert.ToString(value); }
        public string Sezione { get => sezione; set => sezione = value; }

        protected string Matricola => matricola;
        public string Specializzazione { get => specializzazione; set => specializzazione = value; }
        
        public clsAlunno(string nome, string cognome, string citta,string classe,string sezione,string specializzazione) 
            : base(nome, cognome, citta)
        {
            Classe = classe;
            Sezione = sezione;
            Specializzazione = specializzazione;
            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5,'0');
        }
        public override string visualizza()
        {
            return Matricola + " " + Nome + " " + Cognome + " " + Citta + " " + Classe + " " + Sezione + " " + Specializzazione;
        }
    }
}

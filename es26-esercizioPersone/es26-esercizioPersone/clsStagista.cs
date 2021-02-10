using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es26_esercizioPersone
{
    class clsStagista:clsAlunno
    {
        #region attributi
        private string azienda;
        private int ore;
        #endregion
        internal string Azienda { get => azienda; set => azienda = value; }
        internal string Ore { get { return ore.ToString(); } set {
                if (Convert.ToInt32(value) < 1)
                {
                    throw new Exception("Numero non valido");
                }
                else ore = Convert.ToInt32(value);
            } 
        }

        public clsStagista(string nome, string cognome, string citta, string classe, string sezione, string specializzazione, string azienda, string ore)
            :base( nome, cognome, citta, classe, sezione, specializzazione)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string visualizza()
        {
            return base.visualizza()+" "+Azienda+" "+Ore;
        }
    }
}

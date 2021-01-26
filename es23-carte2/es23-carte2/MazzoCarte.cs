using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es23_carte2
{
    class MazzoCarte: Carte
    {
        Random r = new Random();
        private int progr;
        private Carte[] collection = new Carte[40];
        List<Carte> collectionappoggio = new List<Carte>();
        private string[] semi = new string[] { "Cuori", "Piche", "Fiore", "Quadri" };
        private string[] valori = new string[] { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };
        Carte c;
        public MazzoCarte():base("","")
        {

        }
        public void InserisciCarta(Carte[] collection)
        {
            while(collection.Contains(c))
            {
                c = new Carte(valori[r.Next(0, 10)], semi[r.Next(0, 4)]);
            }
            collection[progr] = c;
            progr++;
        }

        public string DammiCarte(Carte[] collection)
        {
            string str = "";
            str = collection[0].Valore + " di " + collection[0].Seme;
            return str;
        }


    }
}

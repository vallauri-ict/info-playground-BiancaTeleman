using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es22_giocoScopa
{
    public class Mazzo : Carta
    {
        Random r = new Random();
        string[] semi = { "ori", "bastoni", "spade", "coppe"};
        private Carta[] collection = new Carta[40];
        Carta c;
        public Mazzo() : base(1, "")
        {
            for (int i = 0; i < 40; i++)
            {
                while(collection.Contains(c))
                {
                     c = new Carta(r.Next(1, 11), semi[r.Next(0, 4)]);
                }
                collection[i] = c;
            }
        }

        public void mescola()
        {
            for (int i = 0; i < 40; i++)
            {
                while (collection.Contains(c))
                {
                    c = new Carta(r.Next(1, 11), semi[r.Next(0, 4)]);
                }
                collection[i] = c;
            }
        }

        public void estrai()
        {

        }
    }
}
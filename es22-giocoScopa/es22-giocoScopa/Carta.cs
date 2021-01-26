using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es22_giocoScopa
{
    public class Carta
    {
        private int valore;
        private string seme;

        public Carta(int valore,string seme)
        {
            Valore = valore;
            Seme = seme;
        }

        public int Valore { get => valore; set => valore = value; }
        public string Seme { get => seme; set => seme = value; }

        public void lettura()
        {
            System.Windows.Forms.MessageBox.Show("il valore vale: "+Valore.ToString());
            System.Windows.Forms.MessageBox.Show("il seme è: "+Seme);
        }
    }
}

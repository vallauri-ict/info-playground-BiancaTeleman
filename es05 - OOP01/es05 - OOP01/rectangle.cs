using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es05___OOP01
{
    class rectangle
    {
        private int side1, side2;
        public Color colore;
        private string descrizione;

        public rectangle() //costruttore che viene generato in automatico se noi non scriviamo niente
        {
            //side1 = 1;
            //side2 = 2;
            descrizione="Sono un rettangolo";
        }
        public rectangle(int baseRettangolo,int altezzaRettangolo)
        {
            side1 = baseRettangolo;
            side2 = altezzaRettangolo;
        }
        public string getSide()
        {
            return "Base: "+side1.ToString() + " Altezza: " + side2.ToString(); 
        }
    }
}

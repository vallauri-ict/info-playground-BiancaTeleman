using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es06_metodoFactory
{
    class quadrato
    {
        private int lato;

        private quadrato(int lato)
        {
            this.lato = lato;
        }
        
        public static quadrato creaQuadrato(int lato)
        {
            if(lato<=0)
            {
                throw new Exception("Il lato del quadrato deve essere > di 0");
            }
            else
            {
                return new quadrato(lato);
            }
        }
    }
}

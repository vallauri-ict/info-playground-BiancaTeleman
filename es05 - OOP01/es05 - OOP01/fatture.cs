using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es05___OOP01
{
    class fatture
    {
        private static int cntFatture = 0;
        public readonly int nFattura;
        public fatture()
        {
            cntFatture++;
            this.nFattura = cntFatture;
        }

        public static void visualizza()
        {
            System.Windows.Forms.MessageBox.Show("Numero fatture create: " + cntFatture);
            //System.Windows.Forms.MessageBox.Show("numero fattura corrente: " + this.nFattura);
        }
    }
}

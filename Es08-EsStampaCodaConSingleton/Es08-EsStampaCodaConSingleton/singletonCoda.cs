using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es08_EsStampaCodaConSingleton
{
    class singletonCoda
    {
        private Queue<string> coda = new Queue<string>();
        private string txt;
        private static singletonCoda instance = null;
        private singletonCoda()
        {

        }

        private singletonCoda(string txt)
        {
            this.txt = txt;
        }
        
        public void aggiungiCoda(string strCoda)
        {
            coda.Enqueue(strCoda);
        }

        public static singletonCoda getSingletonQueue()
        {
            if (instance == null)
            {
                instance = new singletonCoda();
            }
            return instance;
        }

        public void stampaCoda()
        {
            
            if(coda.Any()) //.Any() mi dice se ci sono elementi nella coda
            {
                System.Windows.Forms.MessageBox.Show(coda.Dequeue());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non ci sono elementi");
            }
           
        }
    }
}

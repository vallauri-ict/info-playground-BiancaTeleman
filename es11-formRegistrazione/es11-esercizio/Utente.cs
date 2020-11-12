using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es11_esercizio
{
    class Utente
    {
        private static Utente instance = null;
        string[] vetUser = new string[999];
        

        private Utente()
        {

        }

       /* private Utente(string txt)
        {
            this.txt = txt;
        }*/

        public static Utente getSingletonQueue()
        {
            if (instance == null)
            {
                instance = new Utente();
            }
            return instance;
        }

        public void creaFile(string _cognome,string _nome, string _indirizzo, string _citta,
                                string _cap, string _mail, string _codice, string _user,string _password)
        {
            bool presente=Utente.presente(_user);
            if(presente)
            {
                System.Windows.Forms.MessageBox.Show("Utente già presente");
            }
            else
            {
                string s;
                StreamWriter sw = new StreamWriter("listaUtenti.txt", true);
                s = _cognome + " " + _nome + " " + _indirizzo + " " + _citta +
                    " " + _cap + " " + _mail + " " + _codice + " " + _user + " " + _password;
                sw.WriteLine(s);
                sw.Close();
            }
        }

        private static bool presente(string _user)
        {
            StreamReader sr = new StreamReader("listaUtenti.txt");
            string s;
            string[] dato = new string[9];
            bool trovato = false;
            if((new FileInfo("listaUtenti.txt").Length == 0))
            {
                while (!trovato && sr.Peek() != -1)
                {
                    s = sr.ReadLine();
                    dato = s.Split(' ');
                    if (dato[7] == _user)
                        trovato = true;
                }
                sr.Close();
                
            }
            return trovato;
        }
    }
}

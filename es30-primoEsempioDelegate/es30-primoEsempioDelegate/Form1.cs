using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es30_primoEsempioDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //dichiarazione del delegate che accetta due parametri interi
        //e restituisce un valore intero
        public delegate int Operazione(int a, int b);
        
        //dichiaro le tre funzioni che utilizzerò con il delegate
        public int Somma(int x,int y)
        {
            return x + y;
        }
        public int Sottrazionea(int x, int y)
        {
            return x - y;
        }
        public int Moltiplicazione(int x, int y)
        {
            return x * y;
        }
        private void btnAddizione_Click(object sender, EventArgs e)
        {
            //Primo Metodo per usare un delegate
            //Istanzio il delegate e come parametro passo il nome della funzione
            Operazione op = new Operazione(Somma); //somma è la funzione puntata dal delegate

            //richiamo il delegate
            MessageBox.Show("Somma= "+op(10,15));
        }

        private void btnProdotto_Click(object sender, EventArgs e)
        {
            //Secondo metodo
            Operazione op = Moltiplicazione;

            //richiamo
            MessageBox.Show("Prodotto= "+op(10,15));
        }
    }
}

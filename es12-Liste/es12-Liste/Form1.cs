using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es12_Liste
{
    public partial class Form1 : Form
    {
        List<book> lstBook = new List<book>();
        public struct Libro /*se non specifico la visibilità le struct le prende private*/
        {
            public int ID;
            public string titolo;
            public string autore;
        }
        List<Libro> miaLista = new List<Libro>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;
            l.ID = Convert.ToInt32(txtID.Text);
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;

            miaLista.Add(l);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach(var elemento in miaLista)
            {
                MessageBox.Show(elemento.titolo);
            }
        }

        private void btnAggiungiObj_Click(object sender, EventArgs e)
        {
            book b = new book(Convert.ToInt32(txtID.Text), txtTitolo.Text, txtAutore.Text);
            lstBook.Add(b); /*aggiungo alla mia lista l'oggetto che contiene le tre textbox*/
        }

        private void btnVisualizzaObj_Click(object sender, EventArgs e)
        {
            foreach (var elemento in lstBook)
            {
                MessageBox.Show("Titolo: "+elemento.titolo+"\nAutore: "+elemento.autore+"\nID: "+elemento.ID);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            book ris = lstBook.Find(bf => (bf.autore==txtAut.Text));
            MessageBox.Show(ris.autore);
           
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            List<book> lstBookAus = new List<book>();
            lstBookAus = lstBook.FindAll(bf => bf.autore == txtAut.Text);
        }
    }
}

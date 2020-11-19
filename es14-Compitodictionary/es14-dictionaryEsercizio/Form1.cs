using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es14_dictionaryEsercizio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct articolo
        {
            public int chiave;
            public string nome;
        }
        Dictionary<int, articolo> d = new Dictionary<int, articolo>();
        public int i = 0; //indice
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            articolo art;
            art.chiave = Convert.ToInt32(txtChiave.Text);
            art.nome = txtNome.Text;
            d.Add(i++, art);
            txtChiave.Text = "";
            txtNome.Text = "";
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            int cont;  /*variabile in più per chiarezza, posso anche usare direttamente d.count*/
            cont = d.Count;
            lblNInserimenti.Text = "Hai inserito: " + cont.ToString() + " articoli";
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            int chiave = Convert.ToInt32(txtChiave.Text);
            lblArticolo.Text = "Articolo cercato: " + d[Convert.ToInt32(txtChiave.Text)].nome;
        }
    }
}

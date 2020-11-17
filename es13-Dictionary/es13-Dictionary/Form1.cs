using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es13_Dictionary
{
    public partial class Form1 : Form
    {
        public struct libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            dizionarioLibri.Add(i,l);
            i++;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach (libro l in dizionarioLibri.Values)
                MessageBox.Show(l.titolo + " " + l.autore);
        }
    }
}

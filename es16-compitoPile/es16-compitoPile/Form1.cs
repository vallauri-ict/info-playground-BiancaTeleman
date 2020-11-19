using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es16_compitoPile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Containers
        {
            public string codice;
            public int peso;
            public int tara;
        }
        Stack<Containers> pila = new Stack<Containers>();
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Containers container;
            container.codice = txtCodice.Text;
            container.peso = Convert.ToInt32(txtPeso.Text);
            container.tara = Convert.ToInt32(txtTara.Text);

            pila.Push(container);
            txtCodice.Focus();
            txtCodice.Text = "";
            txtPeso.Text = "";
            txtTara.Text = "";
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            
            if (pila.Count!=0)
            {
                MessageBox.Show("Codice: " + pila.Peek().codice+"\nPeso: "+pila.Peek().peso+" kg\nTara: "+pila.Peek().tara);
                pila.Pop();
            }
            else
            {
                MessageBox.Show("Pila vuota");
            }
        }
    }
}

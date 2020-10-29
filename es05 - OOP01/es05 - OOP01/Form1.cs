using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es05___OOP01
{
    public partial class Form1 : Form
    {
        rectangle r;
        public Form1()
        {
            InitializeComponent();
            r = new rectangle();
        }

        private void btnCreaRettangolo_Click(object sender, EventArgs e)
        {
            /*r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            rectangle t;
            t = r;
            //puntano entrambi alla stessa area di memoria e se ne modico uno si modifica anche l'altro
            MessageBox.Show("Base: "+r.side1+"\nAltezza: "+r.side2);
            MessageBox.Show("Per l'oggetto t\nBase: " + t.side1 + "\nAltezza: " + t.side2);
            t.side1 = 10;
            MessageBox.Show("Per l'oggetto r dopo modifiche su t\nBase: " + r.side1 + "\nAltezza: " + r.side2);*/
            r.colore = Color.White;
            
            r = new rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(r.getSide());
            MessageBox.Show(r.getSide());

            r = new rectangle();
            r.colore = Color.White;
            MessageBox.Show(r.getSide());
        }

        private void btnVisualizzaNfattura_Click(object sender, EventArgs e)
        {
            fatture.visualizza();
        }

        private void btnCreaFattura_Click(object sender, EventArgs e)
        {
            fatture f = new fatture();
            MessageBox.Show("Fattura creata!");
            //f.visualizza();
        }

        private void btnClasseStatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pigreco: "+miaMath.pi+"n3*4= "+miaMath.prodotto(3,4));
        }
    }
}

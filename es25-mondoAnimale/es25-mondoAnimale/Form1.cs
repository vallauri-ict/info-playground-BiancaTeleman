using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es25_mondoAnimale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAnimali_Click(object sender, EventArgs e)
        {
            Cavallo c = new Cavallo("Furia del West");
            c.mostra();
            Uomo h = new Uomo("Johnny");
            h.mostra();
            Corvo w = new Corvo("Il corvo dell'uva");
            w.mostra();
            Tonno t = new Tonno("Palmera");
            t.mostra();
            Uccello u = new Uccello("Gabbiano");
            u.mostra();
            Pinguino p = new Pinguino("Tweety");
            p.mostra();
        }
    }
}

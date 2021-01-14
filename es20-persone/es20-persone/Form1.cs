using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es20_persone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Studente> lstStudenti = new List<Studente>();
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.setAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
            lstStudenti.Add(s);
            listStudente.Items.Add(s.getCognome());
        }

        private void listStudente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cognome = listStudente.SelectedItems[0].Text;
            foreach (var item in lstStudenti)
            {
                if(item.getCognome()==cognome)
                {
                    item.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            foreach
        }
    }
}

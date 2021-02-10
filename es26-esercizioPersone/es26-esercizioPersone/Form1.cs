using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es26_esercizioPersone
{
    public partial class Form1 : Form
    {
        clsElenco elencoStudenti;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new clsElenco();
        }
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            clsAlunno stu;
            if(txtOreStage.Text.Trim()=="")
            {
                stu = new clsAlunno(txtNome.Text,txtCognome.Text,txtCitta.Text,
                    cmbClasse.SelectedItem.ToString(),cmbSezione.SelectedItem.ToString(),cmbSpec.SelectedItem.ToString());
            }
            else
            {
                stu = new clsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text,
                    cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(),
                    cmbSpec.SelectedItem.ToString(), cmbAziende.SelectedItem.ToString(), txtOreStage.Text);
            }
            elencoStudenti.Inserisci(stu);
            elencoStudenti.VisualizzaDGV(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if(c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAziende.SelectedItem.ToString();
            int ore = elencoStudenti.oreAzienda(azienda);
            if(ore!=0)
            {
                MessageBox.Show("Gli stagisti hanno effettuato "+ore+" ore in "+azienda,"information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non è stata effettuata alcuna ora in "+azienda,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPosizione.Text == "")
                {
                    elencoStudenti.cancella();
                }
                else
                {
                    elencoStudenti.cancella(Convert.ToInt32(txtPosizione.Text));
                }
                MessageBox.Show("Cancellazione effettuata");
                elencoStudenti.VisualizzaDGV(dgvStudenti);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

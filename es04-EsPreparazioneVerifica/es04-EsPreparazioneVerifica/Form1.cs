using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es04_EsPreparazioneVerifica
{
    public partial class Form1 : Form
    {
       // private TextBox txtModifica2;
        public formFiglia figlia;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void newSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "Aperta Form Secondaria";
            formSecondaria f2 = new formSecondaria(txtNome,txtEta);
            f2.Text = "form Secondaria";
            f2.Show();
            

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "Load";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "Save";
        }

        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "Form Figlia";
            //formFiglia figlia = new formFiglia(txtModifica);
            figlia = new formFiglia(txtModifica);
            figlia.Text = "Form Figlia";
            figlia.Show();
        }

        private void newMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "Form MDI";
            formMdi fMdi = new formMdi();
            fMdi.Show();
        }

        private void newDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "Form Dianamica";
            Form fDinamica = new Form();
            fDinamica.Text = "Aperta form dinamica";
            fDinamica.Show();
        }

        private void info_Click(object sender, EventArgs e)
        {
            statusStriplbl.Text = "?";
            formInfo fInfo = new formInfo();
            fInfo.Show();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            /*formFiglia fFiglia2 = new formFiglia(txtModifica);
            fFiglia2.Show();*/
            figlia.TxtValue = txtModifica.Text;
         
        }
    }
}

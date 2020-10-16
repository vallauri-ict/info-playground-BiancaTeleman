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
    
    public partial class formSecondaria : Form
    {
        private TextBox txtNome2;
        private TextBox txtEta2;
        public formSecondaria()
        {
            InitializeComponent();
        }
        public formSecondaria(TextBox txtNome2, TextBox txtEta2)
        {
            InitializeComponent();
            this.txtNome2 = txtNome2;
            this.txtEta2 = txtEta2;
        }

        
        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNomef2.Text+" "+txtEtaf2.Text);
            txtNome2.Text = txtNomef2.Text;
            txtEta2.Text = txtEtaf2.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operazione Annullata");
            Close();
        }
    }
}

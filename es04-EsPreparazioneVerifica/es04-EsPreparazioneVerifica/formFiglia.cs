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
    public partial class formFiglia : Form
    {
        private TextBox txtPadre;
        private TextBox txtModificaff;
        private string txtValue;
        public formFiglia()
        {
            InitializeComponent();
        }
        public formFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.txtPadre = txtPadre;
        }

        public string TxtValue 
        { 
            get => txtValue;
            set
            {
                txtValue = value;
                txtPadre.Text = txtValue;
            }
        }

        private void btnModifica2_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtModificaFfiglia.Text;
        }
    }
}

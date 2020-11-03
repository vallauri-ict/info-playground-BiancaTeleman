using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es08_EsStampaCodaConSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungiCoda_Click(object sender, EventArgs e)
        {
            if(txtCoda.Text!="")
            {
                singletonCoda s = singletonCoda.getSingletonQueue();
                s.aggiungiCoda(txtCoda.Text);
                txtCoda.Text = "";
            }
            else
            {
                MessageBox.Show("scrivi qualcosa nella textbox");
            }
           
        }

        private void btnStampaCoda_Click(object sender, EventArgs e)
        {
            singletonCoda s = singletonCoda.getSingletonQueue();
            s.stampaCoda();
        }
    }
}

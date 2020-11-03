using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es07_classSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaClasse_Click(object sender, EventArgs e)
        {
            esSingleton s = esSingleton.getEsSingleton(Convert.ToInt32(txtClasse.Text)); //non metto new perchè non è un costruttore
            MessageBox.Show("valore = "+s.val);
            esSingleton s1 = esSingleton.getEsSingleton(0);
            MessageBox.Show("valore di s1 = "+s1.val);
            MessageBox.Show("valore di s = "+s.val);

        }
    }
}

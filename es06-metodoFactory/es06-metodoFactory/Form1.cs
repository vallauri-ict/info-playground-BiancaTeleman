using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es06_metodoFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            quadrato q;
            if(txtLato.Text!="")
            {
                try
                {
                    q = quadrato.creaQuadrato(Convert.ToInt32(txtLato.Text));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Compilare il campo");
            }
            
        }
    }
}

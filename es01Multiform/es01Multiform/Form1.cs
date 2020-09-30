using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es01Multiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("ciao"); //istanzio - form2 è appunto la form creata prima staticamente
            f2.Show(); //mi fa visualizzare la form
        }

        private void btnForm2b_Click(object sender, EventArgs e)
        {
            //creare una form dinamicamente
            Form f2b = new Form(); //Form è la classe e la uso per crearmi la form2 dinamica
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }
    }
}

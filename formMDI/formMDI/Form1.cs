using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApriF1_Click(object sender, EventArgs e)
        {
            //form interna a form1
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 1";
            f.MdiParent = this; //imposto la form come parent
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual; //serve per far dire alla form che la metto io la posizione e non windows
            f.Location = new Point(0, 20);
            f.Show();
        }

        private void btnApri2_Click(object sender, EventArgs e)
        {
            //form interna a form1
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 2";
            f.MdiParent = this; //imposto la form come parent
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual; //serve per far dire alla form che la metto io la posizione e non windows
            f.Location = new Point(215, 20);
            f.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte "+this.MdiChildren.Length+" finestre"); 
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra "+f.Text+" Aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modalEsci f = new modalEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog()==DialogResult.OK)
            {
                Close(); //chiudo la finestra
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 2";
        }
    }
}

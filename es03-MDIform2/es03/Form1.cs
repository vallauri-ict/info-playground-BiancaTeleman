using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia1 f = new FormFiglia1();
            f.Text = "Figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 20);
            f.Show();
            toolStripStatusLbl.Text = "Premuto Apri 1";
        }

        private void apriF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia2 f = new FormFiglia2();
            f.Text = "Figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(215, 20);
            f.Show();
            toolStripStatusLbl.Text = "Premuto Apri 2";
        }

        private void finestreAperteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Finetre Aperte";
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + f.Text + " Aperta");
            }
            
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Esci";
            FormEsci f = new FormEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
            
        }
    }
}

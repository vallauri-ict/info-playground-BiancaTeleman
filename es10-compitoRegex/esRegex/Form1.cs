using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisciTarga_Click(object sender, EventArgs e)
        {
            //Regex rgxT = new Regex("^[A-Z]{2}\\s[0-9]{3}\\s[A-Z]{2}$");
            string strRgx = @"^[A-Z]{2}\s[0-9]{3}\s[A-Z]{2}$";  //@ davanti alla stringa mi ignora il \\s e posso scriverlo come \s normale
            if (Regex.IsMatch(txtTarga.Text, strRgx,RegexOptions.IgnoreCase)) //ignoreCase non fa differenze tra minuscole e maiuscole
            {
                MessageBox.Show("corrisponde");
            }
            else
            {
                MessageBox.Show("non corrisponde");
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Regex rgxP = new Regex("^[a-zA-Z]{8}\\d{3}[-?@]$");
            if (rgxP.IsMatch(txtPass.Text))
            {
                MessageBox.Show("corrisponde");
            }
            else
            {
                MessageBox.Show("non corrisponde");
            }
        }
    }
}

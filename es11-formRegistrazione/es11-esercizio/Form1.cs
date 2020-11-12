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

namespace es11_esercizio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;
            

            //cognome 1^ lettera maiuscola e le altre minuscole
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if(txtCognome.Text=="")
            {
                MessageBox.Show("Cognome non valido");
                valido = false;
                txtCognome.BackColor = Color.Salmon; 
            }
            else if(!regCognome.IsMatch(txtCognome.Text))
            {
                MessageBox.Show("Cognome inserito non valido");
                valido = false;
                txtCognome.BackColor = Color.Salmon;
            }
            

            //nome
            Regex regnome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (txtNome.Text == "")
            {
                MessageBox.Show("nome non valido");
                valido = false;
                txtNome.BackColor = Color.Salmon; 
            }
            else if (!regnome.IsMatch(txtNome.Text))
            {
                MessageBox.Show("nome inserito non valido");
                valido = false;
                txtNome.BackColor = Color.Salmon;
            }
            

            //indirizzo
            Regex regIndirizzo = new Regex(@"^[A-Z]{1}[a-z]{2,}\s[A-Z]{1}[a-z]{2,}\s\d+$");
            if (txtIndirizzo.Text == "")
            {
                MessageBox.Show("Indirizzo non valido");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }
            else if (!regIndirizzo.IsMatch(txtIndirizzo.Text))
            {
                MessageBox.Show("Indirizzo inserito non valido");
                valido = false;
                txtIndirizzo.BackColor = Color.Salmon;
            }
            

            //Città
            Regex regCitta = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            if (txtCitta.Text == "")
            {
                MessageBox.Show("citta non valida");
                valido = false;
                txtCitta.BackColor = Color.Salmon;
            }
            else if (!regCitta.IsMatch(txtCitta.Text))
            {
                MessageBox.Show("citta inserito non valida");
                valido = false;
                txtCitta.BackColor = Color.Salmon;
            }
            

            //CAP
            Regex regCap = new Regex(@"\d{5}");
            if (txtCap.Text == "")
            {
                MessageBox.Show("cap non valido");
                valido = false;
                txtCap.BackColor = Color.Salmon;
            }
            else if (!regCap.IsMatch(txtCap.Text))
            {
                MessageBox.Show("cap inserito non valido");
                valido = false;
                txtCap.BackColor = Color.Salmon;
            }
            
            //mail
            Regex regMail = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (txtMail.Text == "")
            {
                MessageBox.Show("mail non valido");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            else if (!regMail.IsMatch(txtMail.Text))
            {
                MessageBox.Show("mail inserito non valido");
                valido = false;
                txtMail.BackColor = Color.Salmon;
            }
            

            //codice fiscale
            Regex regCodice = new Regex(@"^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$");
            if (txtCodFiscale.Text == "")
            {
                MessageBox.Show("codice non valido");
                valido = false;
                txtCodFiscale.BackColor = Color.Salmon;
            }
            else if (!regCodice.IsMatch(txtCodFiscale.Text))
            {
                MessageBox.Show("codice inserito non valido");
                valido = false;
                txtCodFiscale.BackColor = Color.Salmon;
            }
           

            //tuttii i vari utenti
            Regex regUser = new Regex(@"\w+");
            if (txtUsername.Text == "")
            {
                MessageBox.Show("user non valido");
                valido = false;
                txtUsername.BackColor = Color.Salmon;
            }
            else if (!regUser.IsMatch(txtUsername.Text))
            {
                MessageBox.Show("user inserito non valido");
                valido = false;
                txtUsername.BackColor = Color.Salmon;
            }
            

            Regex regPass = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}");
            if (txtPassword.Text == "")
            {
                MessageBox.Show("password non valido");
                valido = false;
                txtPassword.BackColor = Color.Salmon;
            }
            else if (!regPass.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("password inserito non valido");
                valido = false;
                txtPassword.BackColor = Color.Salmon;
            }

            if(valido)
            {
                Utente u = Utente.getSingletonQueue();
                u.creaFile(txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCitta.Text, txtCap.Text, txtMail.Text, txtCodFiscale.Text,
                                                                                                    txtUsername.Text, txtPassword.Text);
            }
            


        }
    }
}

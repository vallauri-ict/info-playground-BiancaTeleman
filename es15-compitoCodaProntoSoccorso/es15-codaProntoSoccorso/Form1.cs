using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es15_codaProntoSoccorso
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public struct Paziente
        {
            public string nome;
            public int eta;
            public string colore;
        }
        int[] cont = new int[4];
        Queue<Paziente> rosso = new Queue<Paziente>();
        Queue<Paziente> giallo = new Queue<Paziente>();
        Queue<Paziente> verde = new Queue<Paziente>();
        Queue<Paziente> bianco = new Queue<Paziente>();
        ArrayList temp = new ArrayList();
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Paziente pazienti;
            pazienti.nome = txtNome.Text;
            pazienti.eta = Convert.ToInt32(txtEta.Text);
            pazienti.colore = txtColore.Text;
            switch(pazienti.colore)
            {
                case "rosso":
                    rosso.Enqueue(pazienti);
                    cont[0]++;
                    break;
                case "giallo":
                    giallo.Enqueue(pazienti);
                    cont[1]++;
                    break;
                case "verde":
                    verde.Enqueue(pazienti);
                    cont[2]++;
                    break;
                case "bianco":
                    bianco.Enqueue(pazienti);
                    cont[3]++;
                    break;
            }
        }

        private void btnMedicoLibero_Click(object sender, EventArgs e)
        {
            
            int randTemp;
            bool isEmpty= controllaCont(cont[0]);
            if(isEmpty==false) //rosso
            {
                lblNome.Text = "Nome: "+rosso.Peek().nome;
                lblEta.Text = "Età: " + rosso.Peek().eta.ToString();
                lblColore.Text = "Nome: " + rosso.Peek().colore;
                randTemp = rnd.Next(30, 45);
                lblTemp.Text = "Temperatura: " + randTemp.ToString();
                temp.Add(randTemp);
                rosso.Dequeue();
                cont[0]--;
            }
            else //isEmpty di rosso==true
            {
                isEmpty = controllaCont(cont[1]);
                if(isEmpty==false) //giallo
                {
                    lblNome.Text = "Nome: " + giallo.Peek().nome;
                    lblEta.Text = "Età: " + giallo.Peek().eta.ToString();
                    lblColore.Text = "Nome: " + giallo.Peek().colore;
                    randTemp = rnd.Next(30, 45);
                    lblTemp.Text = "Temperatura: " + randTemp.ToString();
                    temp.Add(randTemp);
                        giallo.Dequeue();
                        cont[1]--;
                }
                else  //isEmpty di giallo==true
                {
                    isEmpty = controllaCont(cont[2]);
                    if (isEmpty == false) //verde
                    {
                        lblNome.Text = "Nome: " + verde.Peek().nome;
                        lblEta.Text = "Età: " + verde.Peek().eta.ToString();
                        lblColore.Text = "Nome: " + verde.Peek().colore;
                        randTemp = rnd.Next(30, 45);
                        lblTemp.Text = "Temperatura: " + randTemp.ToString();
                        temp.Add(randTemp);
                        verde.Dequeue();
                        cont[2]--;
                    }
                    else  //isEmpty di verde==true e quindi passo al bianco e all'ultimo
                    {
                        if (bianco.Count == 0)
                        {
                            MessageBox.Show("pazienti finiti");
                        }
                        else
                        {
                            lblNome.Text = "Nome: " + bianco.Peek().nome;
                            lblEta.Text = "Età: " + bianco.Peek().eta.ToString();
                            lblColore.Text = "Nome: " + bianco.Peek().colore;
                            randTemp = rnd.Next(30, 45);
                            lblTemp.Text = "Temperatura: " + randTemp.ToString();
                            temp.Add(randTemp);
                            bianco.Dequeue();
                            cont[3]--;
                        }
                    }
                }

            }

        }

        private bool controllaCont(int v)
        {
            if(v==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            int min = 50;
            int max = 0;
            for (int i = 0; i < temp.Count - 1;i++)
            {
                if((int)temp[i]>max) /*essendo che temp è un object lo devo castare*/
                {
                    max = (int)temp[i];
                }
                if((int)temp[i]<min)
                {
                    min= (int)temp[i];
                }
            }
            MessageBox.Show("Temperatura minima: "+min.ToString());
            MessageBox.Show("Temperatura massima: "+max.ToString());
        }
    }
}

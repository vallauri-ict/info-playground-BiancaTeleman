﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es28_interfaccia2
{
    public partial class Form1 : Form
    {
        Persona[] vect = { new Persona("Luca","Briaudo","Fossano"),
                         new Persona("Antonio","Aonelli","Alba"),
                         new Persona("Samuele","Stefirca","Savigliano")};
        public Form1()
        {
            InitializeComponent();
            ShowPersona();
        }

        public void ShowPersona()
        {
            string s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            Array.Sort(vect);
            ShowPersona();
        }
    }
}
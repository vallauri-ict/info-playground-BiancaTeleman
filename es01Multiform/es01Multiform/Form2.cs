﻿using System;
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
    public partial class Form2 : Form
    {
        private static String str;
        public Form2(String str2)
        {
            str = str2;
            InitializeComponent(str);
            
        }
        

    }
}

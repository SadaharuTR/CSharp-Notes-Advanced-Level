﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayiKontrol nesne = new SayiKontrol();
            nesne.SayiDurumu += new SayiKontrol.SayiKontrolEtHandler(kontrol);
            nesne.Sayi = 7;
            textBox1.Text = nesne.Sayi.ToString();
        }
        void kontrol()
        {
            MessageBox.Show("Sayi özelliği 10 dan küçük olamaz");
        }
    }
}


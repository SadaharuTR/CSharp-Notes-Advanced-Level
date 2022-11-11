using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            EkleFunc fonksiyonlar = null;
            fonksiyonlar += ElmaEkle;
            fonksiyonlar += PortakalEkle;

            Ekle(fonksiyonlar);

            //EkleFunc fonksiyon = ElmaEkle;
            //Ekle(fonksiyon);

            //Ekle(ElmaEkle);
            //Ekle(PortakalEkle);
        }
        private void Ekle(EkleFunc ekleFunc)
        {
            //ekleFunc();
            ekleFunc.Invoke();

        }

        private void ElmaEkle()
        {
            alinacaklarListBox.Items.Add("Elma");
        }
        private void PortakalEkle()
        {
            alinacaklarListBox.Items.Add("Portakal");
        }

    }
}
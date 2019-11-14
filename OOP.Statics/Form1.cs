using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Statics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            FizikKutuphanesi fk = new FizikKutuphanesi();
            double pi = fk.PI;
            */

            FizikKutuphanesi.PI = 1234;
            double pi = FizikKutuphanesi.PI;

            double pi1 = FizikKutuphanesi.PI;
            double pi2 = FizikKutuphanesi.PI;
            double pi3 = FizikKutuphanesi.PI;
            double pi4 = FizikKutuphanesi.PI;
            double pi5 = FizikKutuphanesi.PI;

            FizikKutuphanesi.PI = 1234; //bunu yapmamızın sebebi işlemi koruma altına almak gibi düşünülebilir. üstteki kısım değişse bile işlem sonunda bu kısım olacağından yine de bu sonucu bu değerde verir.
            double pi6 = FizikKutuphanesi.PI;

            FizikKutuphanesi fk = new FizikKutuphanesi();
            string _readonly = fk.Connection;

            string _connection = FizikKutuphanesi.ConnectionString;

            bool result = FizikKutuphanesi.Sale(1);
            MessageBox.Show("Satış işlemi başarı" + (result ? "lı":"sız"));

            /*
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.Clear();
            */

            Kutuphane.Clear();
        }
    }
}

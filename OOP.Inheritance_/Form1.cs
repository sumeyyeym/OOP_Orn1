using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Inheritance_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BasePhone basephone = new BasePhone("alcatel","kablolu"); Burada parantez içerisinde verileri girdik-- YA DA --

            BasePhone basephone = new BasePhone();
            basephone.Brand = "Samsung";
            basephone.ConnectionType = "Kablolu"; //burada ise verileri metodları çağırarak ayrı satırlara yazdık

            MessageBox.Show(basephone.Sound());

            MobilPhone mobil = new MobilPhone();
            mobil.Brand = "Nokia";
            mobil.ConnectionType = "Mobil";
            mobil.HasCamera = false;
            mobil.IsTouched = false;

            MessageBox.Show(mobil.Sound());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Employees
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

        public override string ToString()//override = çok biçimlilik. eğer ilgili nesne içinde bir komut işe yaramıyorsa ezer, yeniden yapılandırır
        {
            return $"{this.Ad} {this.Soyad}";
        }        
    }
}

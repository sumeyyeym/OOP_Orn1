using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance_
{
    class SmartPhone : MobilPhone
    {
        //SmartPhone : MobilePhone olacak (2 constructor) ve sound metodu yeniden düzenlenecek
        //second camera bool

        public bool SecondCamera { get; set; }

        public SmartPhone()
        {
            _phonetype = "Akıllı Telefon";
        }

        public SmartPhone(bool secondcamera, bool hascamera, bool istouched, string brand, string connectiontype) : base(hascamera, istouched, brand, connectiontype)
        {
            this.SecondCamera = secondcamera;
            _phonetype = "Akıllı Telefon";
        }

        public override string Sound()
        {
            return "Akıllı Telefon Sesi";
        }
    }
}

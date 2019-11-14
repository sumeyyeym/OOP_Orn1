using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance_
{
    public class MobilPhone : BasePhone //miras verme işlemi bu şekildedir. böylece base phone içerisinde kullandığımız yapılara mobilphonedan da ulaşabilir.
    {
        public bool HasCamera { get; set; }
        public bool IsTouched { get; set; }


        public MobilPhone()
        {
            _phonetype = "Mobil Phone";
        }

        public MobilPhone(bool hascamera, bool istouched, string brand, string connectiontype) : base(brand, connectiontype)
        {
            this.HasCamera = hascamera;//this, bu sınıftan aldığı özelliklere işaret eder
            this.IsTouched = istouched;
            //base.Brand = brand;//base ise miras aldığı sııftakilere işaret eder -- ayrıca tek tek önceki clasta belirlenen verileri bu şekilde girmek yerine yukarıda arantez sonrasında verilen base sayesinde miras aldığı kısımdaki veriler arasında iletişim kurulmuş olur. aksi takdirde yapılacak her değişimde tek tek her classın düzenlenmesi gerek. O yüzden veri işlenmesi ve düzenlenmesi için mirastakiler kullanılır ve sen yalnızca yeni kurduğun classtaki yeni verilerini düzenlersin 
            _phonetype = "Mobil Phone";
        }

        public string TakePhoto()
        {
            if (this.HasCamera)
            {
                return "You can take a photo";
            }
            else
            {
                return "Git kamera taktır balam";
            }
        }

        public override string Sound()
        {
            return "Mobil telefon sesi.";
        }
    }
}

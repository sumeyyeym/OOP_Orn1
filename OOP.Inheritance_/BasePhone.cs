using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance_
{
    public class BasePhone
    {
        private string _brand;
        protected string _phonetype;
        protected string _connectiontype;

        public BasePhone()
        {
            _phonetype = "Ahizeli Telefon";
        }

        /// <summary>
        /// Base phone oluşturmak için kullanılan class
        /// </summary>
        /// <param name="brand">Marka</param>
        /// <param name="connectiontype">Bağlantı türü</param>

        public BasePhone(string brand, string connectiontype)
        {
            this._brand = brand;
            this._connectiontype = connectiontype;
            this._phonetype = "Ahizeli Telefon";
        }

        /// <summary>
        /// Telefonun marka bilgisini giriniz.
        /// </summary>
        public string Brand // yukarıda private olan brand kısmını formdan veri alıp saklaaybileceği hale getirmek için bunu yaptık. dışarıdan marka adını alıyor ve alınan markayı set ediyor.
        {
            get{ return _brand; }
            set{ this._brand = value; }
        }


        /// <summary>
        /// Telefaonun bağlantı türünü giriniz.
        /// </summary>
        public string ConnectionType
        {
            get { return _connectiontype; }
            set { this._connectiontype = value; }
        }

        /// <summary>
        /// Telefon çaldığında default olarak belirlenen zil sesini teslim eder.
        /// </summary>
        /// <returns></returns>
        public virtual string Sound() //virtual, override edilebilir (ezilebilir) demektir. Bu sayede mobilphone classında sound yapısında yaptığımız değişiklikle aynı yapıa farklı seçenekler belirlemiş olduk.
        {
            return "Klasik Telefon Sesi";
        }

        public string ConnectionStatus()
        {
            return "Kablolu bağlantı mevcut";
        }
    }
}

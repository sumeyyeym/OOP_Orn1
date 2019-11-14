using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Statics
{
    class FizikKutuphanesi
    {
        public static double PI = 3.1415926;//static olarak işaretlenen nesnelerden 2. bir tane oluşturma şansınız yoktur. ram üzerinde yalnızca bir tane tanımlanır ve proje çalışmaya devam ettiği sürece kullanılmaya devam eder.
        public readonly string Connection = "server=.;database=northwind;uid=sa;pwd=123"; //readonly -- sadece okunabilir, üzerinde değişim yapılamaz.
        public const string ConnectionString = "server=.;database=northwind;uid=sa;pwd=123"; //const (constant) readonly + static
                
        public static bool Sale (int Id) //veri tabanında Id değerinde sahip olanan ürünü sat
        {
            return true; //işlem başarılı olursa true, olmazsa false teslim eder
        }
    }

    public static class Kutuphane
    {
        public static void Clear()
        {
            
        }
    }
}

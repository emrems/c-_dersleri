using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Metot_ve_Değişken_kullanımı
{
    public class Person
    {
        public static string Name { get; set; }
        public static void BilgileriGetir()
        {
            Console.WriteLine("emre almamış");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Yapıcı_Metot_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {   //bir class içinde static constructor varsa ilk o çalışır, sonra diğer construuctor çalışır.
            //static constructorun erişim belirleyicisi olmaz. yani prrivate,public vs olmaz
            //static constructor parametre  almaz
            //bir class'tann kaç tane nesne oluşturulursa oluştrulsun static constructor sadece bir defa çalışır. Sonraki nesnelerde sadece normal constructor çalışır



            Kullanici k1= new Kullanici(1,"emre","almamış");
            k1.zamYap(1000);

            Console.ReadLine();
        }
    }
}

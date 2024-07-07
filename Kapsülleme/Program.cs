using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kapsulleme yapabilmek için geter seter metotları yada property ile yapabiliriz
            //public olursa her yerden ulaşabiliriz
            //private olursa sadece class içinden erişebilirim
            /* normalde biz private bir değişkene veya methoda dışarıdan erişemiyoruz. Ancak set ve get fonksiyonları ile erişebiliriz.(properity ile de erişşebilirz)
               set fonksiyonu ile private olan değişkene değer atabiliriz get fonksiyonu ile de çağırabiliriz.                
             
            */
            Ögrenci ögrenci1 = new Ögrenci();
            ögrenci1.setIsim("emre");
            string gelenİsim = ögrenci1.getIsim();
            Console.WriteLine(gelenİsim);

            Console.ReadLine();

            

        }
    }
}

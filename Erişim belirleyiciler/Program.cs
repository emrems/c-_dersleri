using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_belirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //private sadece class içinden erişilebilir. Dışarıdan herhangibir şekilde erişim sağlanamaz
            //public erişim belirleyici ise heryerden ulaşılabilir.
            //Internal bulunduğu proje içerisinden her yerden erişilebilen bir erişim belirleyicisidir. Fakat başka projeden erişilemez
            //protected bulunduğu class içinden erişilen ve bulunduğu class'ı miras alan classlar içinden erişilir
            isci isci1 = new isci();
            isci1.bilgileriGetir();
            Console.WriteLine(isci1.id);
            Console.WriteLine(isci1.isim);
            isci1.soyisim = "almamış";
            Console.WriteLine(isci1.soyisim);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_değişken_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------STATİC DEĞİŞKEN KULLANIMI-------------------
            //eğer static olarak tanımlanırsa değişken direkt class üzerinden erişebiliriz.
            Person.tc = "22222222";
            Console.WriteLine(Person.tc);
            
            Console.ReadLine();

        }
    }
}

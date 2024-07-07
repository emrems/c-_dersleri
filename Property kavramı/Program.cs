using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.KİLO = 34;//değer ataması yaptım set fonksiyonu çalışacak. Eğer atama yapmasaydım get fonksiyonu çalışacaktı
            Console.WriteLine(musteri1.KİLO);

            Console.ReadLine();
            
        }
    }
}

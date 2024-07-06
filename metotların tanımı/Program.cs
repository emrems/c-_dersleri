using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotların_tanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            selamVer();
            topla(3, 4);
            BilgileriGetir("emre","almamış");
            Console.ReadLine();
        }

        static void selamVer()
        {
             Console.WriteLine("merhaba");
        }

        static void topla(int sayi1,int sayi2)
        {
            Console.WriteLine("sonuc"+ (sayi1 + sayi2));
        }

        static void BilgileriGetir(string isim, string soyad)
        {
            Console.WriteLine("isim :"+isim + "soyisim : " + soyad);
        }
    }
}

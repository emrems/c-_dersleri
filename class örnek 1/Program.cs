using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_örnek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ögrenci ögrenci1 = new Ögrenci(3223,"emre","almamıs",65,87,89,"SUBU");
            bool kontrol = true;
            while (kontrol)
            {
                int gelenSecim = secimYap();
                switch (gelenSecim)
                {
                    case 1:
                        ögrenci1.ogrenciBilgileriGetir();
                        break;
                    case 2:
                        double not = ögrenci1.ortalamaGetir();
                        Console.WriteLine(not);

                        break;
                    case 3:
                        ögrenci1.okulGetir();
                        break;
                    case 4:
                        Console.WriteLine("çıkış yapılıyor");
                        break;
                    default:
                        Console.WriteLine("lütfen geçerli bir seçim yapınız");
                        break;

                }
            }
           
            Console.ReadLine();

        }

        static int secimYap()
        {
            Console.WriteLine("1- öğrenci bilgileri göster");
            Console.WriteLine("2-öğrenci ortalaması göster");
            Console.WriteLine("3-öğrenci okul öğren");
            Console.WriteLine("4-çıkış yap");

            Console.WriteLine("lütfen bir seçim yapınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            return secim;

        }
    }
}

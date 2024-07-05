using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "emre";

            string soyIsim = "almamis";

            int hak = 3;

            while (hak > 0)
            {
                if (hak == 1)
                {
                    Console.WriteLine("lütfen dikkat son hakkınız");
                }
               

                Console.WriteLine("lütfen  adınızı giriniz");
                string gelenİsim = Console.ReadLine();


                if(gelenİsim == isim)
                {

                    Console.WriteLine("lütfen soyadınızı giriniz");
                    string gelenSoyad = Console.ReadLine(); 

                    if (gelenSoyad == soyIsim)
                    {
                        Console.WriteLine("merhaba" + isim+ soyIsim + "başarılı bir şekilde giriş yaptınız");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("soyisim hatalıdır!!");
                    }
                }
                else
                {
                    Console.WriteLine("isim hatalıdır!!");
                }
                hak--;
            }
            Console.ReadLine();


        }
    }
}

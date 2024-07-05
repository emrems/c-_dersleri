using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_ile_atm_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hangi işlemi yapmak istediğinizi seçiniz");
            Console.WriteLine("Bakiye öğrenmek için 1");
            Console.WriteLine("Para çekmek  için 2");
            Console.WriteLine("Para yatırmak için 3");
            Console.WriteLine("Çıkış yapmak için 4");

            int choose = Convert.ToInt32(Console.ReadLine());

            int bakiye = 100;

            switch(choose)
            {
                case 1:
                    Console.WriteLine("bakiyeniz:" + bakiye);
                    break;

                case 2:
                    Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                    if (bakiye >= cekilecekTutar)
                    {
                        Console.WriteLine("kalan paranız:" + (bakiye - cekilecekTutar));
                    }
                    else
                    {
                        Console.WriteLine("yeterli paranız yok");
                           
                    }
                    break;
                 
                case 3:
                    Console.WriteLine("yatırılacak tutarı giriniz");
                    int yatiralacakTutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("toplam bakiyeniz" + (bakiye+yatiralacakTutar));
                    break;

                case 4:
                    Console.WriteLine("çıkış yapılıyor");
                    break;
                
                default:
                    Console.WriteLine("lütfen geçerli bir seçim yapınız");
                    break;

              






            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_yapısı
{
    public class Program
    {
        static void Main(string[] args)
        {
            //enum sıralandırma denebilir aslında switch case gibi. 1 ise bu olsun 2 ise bu olsun gibi şeylerde kullanılır
            //eğer başlangıç değeri vermezsek 0 dan başlatır

            //gunler tipinde pazartsiyi tuttuğum için gun'de gunler tipinde olmalı
            Gunler gun = Gunler.pazartesi;
            if(gun == Gunler.pazartesi)
            {
                Console.WriteLine("bugun pazartesidir");
            }
            else if(gun == Gunler.salı)
            {

                Console.WriteLine("bugun salıdır");
            }
            else if (gun == Gunler.çarşamba)
            {

                Console.WriteLine("bugun çarşamba");
            }
            else if (gun == Gunler.perşmebe)
            {

                Console.WriteLine("bugun perşmebe");
            }
            else if (gun == Gunler.cuma)
            {

                Console.WriteLine("bugun cuma");
            }
            else if (gun == Gunler.cumartesi)
            {

                Console.WriteLine("bugun cumartesi");
            }
            else if (gun == Gunler.pazar)
            {

                Console.WriteLine("bugun pazar");
            }
            Console.ReadLine();

        }
    }
}

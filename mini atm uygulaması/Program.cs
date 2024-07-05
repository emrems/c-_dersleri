using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_atm_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int bakiye = 1000;
            Console.WriteLine("hangi işlemi yapmak istersiniz Bakiye görüntleme için 1'e basınız");

            string choose = Console.ReadLine();

            if (choose == "1") {
                Console.WriteLine("bakiyeniz" + bakiye);

            }else if (choose == "2")
            {
                Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                int çekilecek_para = Convert.ToInt32(Console.ReadLine());

                if (bakiye > çekilecek_para)
                {
                    Console.WriteLine("kalan tutar:" + (bakiye - çekilecek_para));
                }
                else
                {
                    Console.WriteLine("Yeterli paranız yok");
                }

            }else if(choose == "3") {

                Console.WriteLine("Para yatırma seçeneğini seçtiniz");
                Console.WriteLine("Yatıralacak tutarı giriniz");
                int tutarilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("toplam paranız" + (bakiye + tutarilacak_tutar));

            }else if(choose == "q")
            {
                Console.WriteLine("çıkış yapılıyor");
            }
            else
            {
                Console.WriteLine("geçerli bir işlem yapınız");
            }
            


            Console.ReadLine();
        }

        
    }
}

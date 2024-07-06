using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_return_pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int deger = kareAl(8);
            if(deger%2 == 0)
            {
                Console.WriteLine("karesi alınan sayı çifttir");
            }
            else
            {
                Console.WriteLine("girilen sayı tektir");
            }*/

            bool sonuc = kontrolEt(19, 2333);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        static int kareAl(int n)
        {
            return n * n;
        }

        static bool kontrolEt(int yas, int para)
        {
            int miktar = 4000;
            bool ehliyetAlabilirmi = true;
            int gerekliYas = 18;

            if (yas >= gerekliYas)
            {
                if (para == miktar)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("yaşnız tutuyor ancak paranız yetmiyor");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("yaşınız küçük");
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[4];
            int adetTek = 0;
            int adetCift = 0;
            int toplamTek = 0;
            int toplamCift = 0;

            for(int i=0; i<dizi.Length; i++)
            {
                Console.WriteLine("dizinin"+i+"ninci elemanlarını giriniz");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    toplamCift += dizi[i];
                    adetCift++;
                }
                else
                {
                    toplamTek += dizi[i];
                    adetTek++;
                }
            }

            if (toplamTek > toplamCift)
            {
                Console.WriteLine("TEK DEĞERLERİN TOPLAMI DAHA BUYUK");
                Console.WriteLine("tek değerlerin adedi" + adetTek);

            }else if(toplamTek < toplamCift)
            {
                Console.WriteLine("cift değerlerin toplamı daha buyuk");
                Console.WriteLine("cift sayıların adedi" + adetCift);
            }
            else
            {
                Console.WriteLine("cift değerlerin toplamı te degerlerin toplamına eşittir");
            }
            Console.ReadLine();
        }
    }
}

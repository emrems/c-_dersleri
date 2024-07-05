using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_contunie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den 10 a kadar sadece 7 ye kadar yaz
            /*
            for(int i=0; i<=10; i++)
            {
                if (i == 7) break;//break çalışırsa gerisi çalışmaz artık
                Console.WriteLine(i);
            }*/



            /*
            for (int i = 0; i <= 10; i++)
            {
                if (i == 7) continue;//continue çalışırsa o kısmı atlar
                Console.WriteLine(i);
            }*/

            //----------------ÇARPIM TABLOSU YAPIMI----------------

             for(int i=0; i<=10; i++)
            {
                for(int j=0; j<=10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i * j));
                }
            }

            Console.ReadLine();
        }
    }
}

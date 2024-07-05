using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.ReadLine();
            */

            // 0' dan 100'e kadar çift sayıları büyükten küçüğe sırala

            int x= 100;
            while(x > 0)
            {
                Console.WriteLine(x);
                x -= 2;
            }
            Console.ReadLine();
        }
    }
}

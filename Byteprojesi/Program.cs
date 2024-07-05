using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byteprojesi
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //byte veri tipi 0-255 arası değer alır
            byte birinci = 5;
            Console.WriteLine(birinci);

            byte max = byte.MaxValue;
            byte min = byte.MinValue;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}

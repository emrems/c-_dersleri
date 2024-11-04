using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ocak ocak = new Ocak();
            Console.WriteLine(ocak.kacSaat());

            Subat subat = new Subat();

            Console.WriteLine(subat.kacSaat());

            Mart mart = new Mart();
            Console.WriteLine(mart.kacSaat());

            Console.ReadLine();
        }
    }
}

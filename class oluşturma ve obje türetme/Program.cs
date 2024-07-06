using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_oluşturma_ve_obje_türetme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.marka = "opel";
            araba1.renk = "mavi";
            araba1.motorCalistir();
            Console.WriteLine(araba1.marka);
            Console.ReadLine();
        }
        
    }
}

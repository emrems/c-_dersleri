using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cİnema_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinema sinema1 = new Sinema(3);

            sinema1.BiletSat();
            sinema1.biletİptal();
            sinema1.bakiyeGoruntule();
            Console.ReadLine();


        }
    }
}

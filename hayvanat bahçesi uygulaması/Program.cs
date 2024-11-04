using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanat_bahçesi_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aslan aslan = new Aslan();
            aslan.setName("emre");
            aslan.sesCikar();

            Kus kus = new Kus();
            kus.setName("reis");
            kus.yemekYe();
            kus.sesCikar();
            Console.ReadLine();
        }
    }
}

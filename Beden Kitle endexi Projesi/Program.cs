using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_endexi_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lütfen boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double endex = kilo / (boy * boy);

            if(endex <=18)
            {
                Console.WriteLine("endexe göre:" +  endex + "ile zayıf");

            }else if(endex>=17 && endex <= 25)
            {
                Console.WriteLine("endexe göre:" + endex + "ile normal");

            }else
            {
                Console.WriteLine("endexe göre:" + endex + "ile obez");
            }

            Console.ReadLine();
        }
    }
}

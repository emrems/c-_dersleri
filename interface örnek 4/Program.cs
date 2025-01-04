using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_örnek_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalisan[] calisanlar = new ICalisan[] { new Yazilimci(), new Pazarlamaci() };

            foreach(var calisan in calisanlar)
            {
                calisan.CalculateSalary();
            }



        }
    }
}

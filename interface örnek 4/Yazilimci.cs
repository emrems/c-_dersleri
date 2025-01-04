using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_örnek_4
{
    public class Yazilimci : ICalisan
    {
        public void CalculateSalary()
        {
            Console.WriteLine("yazilimci maası hesaplanıyor.");
        }
    }
}

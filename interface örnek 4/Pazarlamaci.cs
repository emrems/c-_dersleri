using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_örnek_4
{
    public class Pazarlamaci : ICalisan
    {
        public void CalculateSalary()
        {
            Console.WriteLine("pazarlamacı maaşı hesaplanıyor");
        }
    }
}

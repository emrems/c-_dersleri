using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödeme_sistemleri
{
    public class Nakit:Payment
    {
        public override void makePayment(decimal amount)
        {
            Console.WriteLine("ödemeniz alınıyor");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeme_yöntemleri_uygulaması
{
    public class Nakit : Odeme
    {
        public override void odemeYap()
        {
            Console.WriteLine("ödeme nakit olarak yapılıyor");
        }
    }
}

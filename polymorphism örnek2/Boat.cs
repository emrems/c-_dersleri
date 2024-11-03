using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek2
{
    public class Boat:Transport
    {
        public override void move(string name)
        {
            Console.WriteLine(name + "boat ses verdi");
        }
    }
}

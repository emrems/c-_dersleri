using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek2
{
    public class Car:Transport
    {
        public override void move(string name)
        {
            Console.WriteLine(name + "ilginç ses verdi");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek2
{
    public class Transport
    {
        public string name;
        public virtual void move(string name)
        {
            Console.WriteLine(name +" ses çıkardı");
        }
    }
}

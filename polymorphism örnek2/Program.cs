using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.move("opel");

            Boat boat = new Boat();
            boat.move("yeni boat");
            Console.ReadLine();
        }
    }
}

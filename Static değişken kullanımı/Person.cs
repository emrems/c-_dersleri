using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_değişken_kullanımı
{
    internal class Person
    {
        public static string tc;
        public Person() {
            
            Console.WriteLine(tc);
        }
    }
}

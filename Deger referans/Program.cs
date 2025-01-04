using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deger_referans
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 7;
            //x = y;

            //y = 9;

            //Console.WriteLine(x); Console.WriteLine(y);

            List<string> sehirler1 = new List<string>();
            List<string> sehirler2 = new List<string>();

            sehirler1.Add("izmir");
            sehirler1.Add("adana");
            sehirler2.Add("muş");
            sehirler2.Add("diyarbakır");

            sehirler1 = sehirler2;

            sehirler1.Add("erzurum");
            sehirler2.Add("kars");
            foreach (string s in sehirler1)
            {
                Console.WriteLine(s);
            }

            foreach (string s in sehirler2)
            {
                Console.WriteLine(s);
            }
        }
    }
}

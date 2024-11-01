using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        /* polymorphism bir classta olan methodun işlevini başka bir classta değiştirmektir. Ana classta virtual anahtar kelimesi verilir. Override edilecek classlarda ise override anaahtar kelimesi kullanılır*/
        static void Main(string[] args)
        {
            /*
            Hayvan hayvan = new Hayvan("hayvan");
            hayvan.konus();

            Kedi kedi = new Kedi("boncuk");
            kedi.konus();

            Kopek kopek = new Kopek("karabaş");
            kopek.konus();
            Console.ReadLine();
            */
            hayvanlarıKOonustur(new Kedi("minnos"));
            hayvanlarıKOonustur(new Kopek("luci"));
            Console.ReadLine();
        }
        public static void hayvanlarıKOonustur(Hayvan hayvan)
        {
            hayvan.konus();
        }
    }
}

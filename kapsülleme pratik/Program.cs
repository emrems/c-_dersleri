using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme_pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen tc kimlik numaranızı giriniz");
            string gelenTc = Console.ReadLine();

            Personel personel = new Personel();
            personel.TC = gelenTc;//set bloğu çalışacak
            Console.WriteLine(personel.TC);//get bloğu çalışacak

            Console.ReadLine();


        }
    }
}

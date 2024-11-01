using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kedi kedi1 = new kedi();
            kedi1.hayvan_isim = "maymun";
            kedi1.hayvan_cinsiyet = "erkek";
            kedi1.hayvan_rengi = "mavi";
            kedi1.bilgileriGetir();
            Console.ReadLine();
        }
    }
}

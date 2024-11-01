using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kedi kedi = new kedi();
            kedi.hayvanİsmi = "maymun";
            kedi.hayvanKilo = 3;
            kedi.kopekAyakSayisi = 4;
            kedi.hayvanRenk = "mavi";
            kedi.kopekCinsiyet = "erkek";
            kedi.hayvanBilgileriGoster();
            Console.ReadLine();
        }
    }
}

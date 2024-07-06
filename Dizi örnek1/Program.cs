using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 4, 6, 8, 3, 6, 3, 7, 8, 9, 10, 11, 12, };
            int sayac = 0;
            Console.WriteLine("lütfen sayi giriniz");
            int girilenDeger = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<sayilar.Length; i++)
            {
                if (sayilar[i] == girilenDeger)
                {
                    sayac++;
                }
                
            }
            
            if(sayac > 0)
            {
                Console.WriteLine("girilen değer" + sayac + "tane mevcuttur.");

            }
            else
            {
                Console.WriteLine("malesef girilen değer mevcut değildir");
            }
           
            Console.ReadLine();
        }
    }
}

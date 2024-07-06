using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] number = new int[4];//burası bana 4 elemanlık bir int dizisi sunar.


            //string[] isimler = { "emre", "ahmet","mehmet" };//burada direkt elemanları ekledik
            //string[] isimler = new string[4];//burada ise string tipinde 4 elemanlık bir dizi ayır ben sonra değer atayacağım


            //double[] ondalikliSayilar = { 3.4, 43.2 };
            //double[] ondalikliSayilar = new double[5];//5 elemanlık double dizisi ayarla demek 


            //char[] chars = { 'A', 'k', 'l' };
            //char[] chars = new char[5]; 


            
            Console.WriteLine("Lütfen dizinin boyutunu giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int [sayi];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("lütfen dizinin değerlerini giriniz");
                sayilar[i]= Convert.ToInt32(Console.ReadLine());

            }
            
            for(int i=0; i < sayilar.Length; i++)
            {
                Console.WriteLine("dizinin "+i+"ninci elemanı : "+i);
            }




            Console.ReadLine();
        }
    }
}

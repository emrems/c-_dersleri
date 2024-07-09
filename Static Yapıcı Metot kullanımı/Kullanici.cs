using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_Yapıcı_Metot_kullanımı
{
    internal class Kullanici
    {
        private int id { get; set; }
        private string isim { get; set; }
        private string Soyİsim { get; set; }
        private static int maas;

        static Kullanici()//static consturctor
        {
            maas = 40000;//static consturactorda bu değişkeni kullanbilmek için maas değişkeni static olmalı
        }
        public Kullanici(int kullanıcıİd, string ad ,string soyAd )//public consturoctor
        {
            id = kullanıcıİd;
            isim = ad;
            Soyİsim = soyAd;
            
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("isim" + isim + "soyisim: " + Soyİsim);
        }

        public void zamYap(int zamMiktarı)
        {
            maas += zamMiktarı;
            Console.WriteLine("yeni maaş" + maas);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Örnek1
{
    public class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdres { get; set; }

        public static ArrayList musteriler = new ArrayList();
        
        
        public MusteriDurum musteriEkle(Musteri musteri)//Musteri durum tipinde bir değer dönecek
        {
            foreach(Musteri mevcutMusteri in musteriler)
            {
                if(mevcutMusteri.emailAdres == musteri.emailAdres)
                {
                    return MusteriDurum.kayitBasarisiz;
                }
            }

            bool baglantiVar = true;
            if (!baglantiVar)
            {
                return MusteriDurum.baglantiHatasi;
            }

            musteriler.Add(musteri);
            return MusteriDurum.kayitBasarili;
            
        }

        public void musterileriGoruntule()
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine($"ID:{musteri.id} İSİM:{musteri.isim} EMAİL:{musteri.emailAdres}");
            }

        }
        
    }
}

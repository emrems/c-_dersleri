using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Örnek1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.isim = "emre";
            musteri1.cinsiyet = "erkek";
            musteri1.emailAdres = "ealmmslfmslfs@gmail.com";


            
            Musteri musteri2 = new Musteri();  
            musteri2.id = 2;
            musteri2.isim = "ali";
            musteri2.cinsiyet = "kadın";
            musteri2.emailAdres = "ali@gamil.com";
            

            
            MusteriDurum durum1 = musteri1.musteriEkle(musteri1);
            MusteriDurum durum2 = musteri2.musteriEkle(musteri2);

            //durumları kontrol etme
            checkDurum(durum1);
            checkDurum(durum2);

            
            musteri1.musterileriGoruntule();
            Console.ReadLine();
        }

        static void checkDurum(MusteriDurum durum)
        {
            switch(durum)
            {
                case MusteriDurum.kayitBasarili:
                    Console.WriteLine("kayıt başarılı");
                    break;
                case MusteriDurum.kayitBasarisiz:
                    Console.WriteLine("kayıt başarısıız");
                    break;
                case MusteriDurum.baglantiHatasi:
                    Console.WriteLine("bağlantı hatası");
                    break;
                default:
                    Console.WriteLine("başka bir hata var");
                    break;

            }
        }
    }
}

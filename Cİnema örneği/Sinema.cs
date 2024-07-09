using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cİnema_örneği
{
    internal class Sinema
    {
        public int salonNo;
        public double bakiye;
        public int koltukSayisi;
        public int bosKoltukSayisi;

        public int koltukNo;
        public const double tamFiyat = 10;
        public const double indirimliFiyat = 5;

        public Sinema(int koltuk_sayisi )
        {
           
            
            koltukSayisi = koltuk_sayisi;
            koltukSayisi=koltuk_sayisi;
            bosKoltukSayisi= koltukSayisi;
            bakiye = 0;
        }

        public bool BiletSat()
        {
            int bos_koltuk = BosKoltukSayisiGoruntule();

            if (bos_koltuk > 0) {
                Console.WriteLine("lütfen bilet tipini giriniz");
                string biletTipi = Console.ReadLine();
                bosKoltukSayisi--;

                if (biletTipi == "Tam")
                {
                    Random random = new Random();
                    for (int i=1; i<= koltukSayisi; i++)
                    {
                        
                        koltukNo  = random.Next(1,10);
                        salonNo = random.Next(1,10);
                        Console.WriteLine(i + ".inci koltuk" + koltukNo + ". koltuk numarası ile" + salonNo + ".salonda rezerve edilmiştir.");
                        
                    }
                    bakiye += tamFiyat*koltukSayisi;

                }
                else if(biletTipi == "İndirimli")
                {
                    Console.WriteLine("biletiniz başarıyla oluşturulmuştur. Koltuk numaranız : " + koltukNo + "salon numaranız : " + salonNo);
                    bakiye += indirimliFiyat*koltukSayisi;
                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir bilet tipi giriniz");
                    bosKoltukSayisi++;
                    return false;
                }
                return true;

            }
            else
            {
                Console.WriteLine("Malesef boş koltuk bulunmamaktadır"); return false;
            }
            
        }

        public void biletİptal()
        {
            
            Console.WriteLine("lütfen bilet tipini giriniz");
            string biletTipi = Console.ReadLine();

            Console.WriteLine("İptal edilecek bilet adedini giriniz");
            int iptalEdilenBiletSayisi = Convert.ToInt32(Console.ReadLine());

            bosKoltukSayisi += iptalEdilenBiletSayisi;
            if (biletTipi == "Tam")
            {
                Console.WriteLine("biletiniz iptal edilmiştir.");
                bakiye -= tamFiyat*iptalEdilenBiletSayisi;
                
            }
            else
            {
                Console.WriteLine("biletiniz iptal edilmiştir.");
                bakiye -= indirimliFiyat*iptalEdilenBiletSayisi;
            }
        }

        public int BosKoltukSayisiGoruntule()
        {
            return bosKoltukSayisi;
        }

        public void bakiyeGoruntule()
        {
            Console.WriteLine("Bakiyeniz : "+bakiye);
        }
    }
}

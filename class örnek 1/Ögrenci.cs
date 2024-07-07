using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_örnek_1
{
    public class Ögrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyad;
        private int vize1;
        private int vize2;
        private string okulİsmi;
        private int final;

        public Ögrenci(int numara, string ad, string soyisim, int sinav1, int sinav2,int final1, string okulAdi)
        {
            ogrenciNo= numara;
            isim= ad;
            soyad= soyisim;
            vize1= sinav1;
            vize2= sinav2;
            okulİsmi= okulAdi;
            final= final1;

        }

        public void ogrenciBilgileriGetir()
        {
            Console.WriteLine("bilgileri istenen öğrencinin adı:" + isim + "dir" + "soyadı" +  soyad + "öğrenci numarası:" + ogrenciNo);
        }

        public void okulGetir()
        {
            Console.WriteLine("okul ismi" + okulİsmi);
        }

        public double ortalamaGetir()
        {

            double ortalama = (vize1 * 0.2) + (vize2 * 0.2) + (final * 0.6);
            return ortalama;
        }

    }
}

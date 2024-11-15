using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class Program
    {
        static void Main(string[] args)
        {

            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
            List<Musteri> musterilerim =  repositoryMusteri.Getir();

            Musteri musteri = new Musteri();
            musteri.isim = "emre";
            musteri.cinsiyet = "erkek";
            string cevap = repositoryMusteri.ekle(musteri);
            Console.WriteLine(cevap);


            Repository<Urun> repositoryUrun = new Repository<Urun>();
            List<Urun> urunlerim =  repositoryUrun.Getir();

            Console.ReadLine();

        }   

    }
}

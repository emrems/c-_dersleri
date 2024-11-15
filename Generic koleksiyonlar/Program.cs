using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList ile generic koleksiyonlar arasındaki temel fark ArrayListte her türden elemanı ekleyebiliyorsun ancak generic koleksiyonlar tek tipteki elemanları eklemek için kullanılır. Bu tipler bizim olşturduğuuz tiplerde olaabilir
            //generic olmayan ArrayList
            //ArrayList koleksiyon = new ArrayList();//ArrayList kullanmak için system.Collection.Generic kütükphanesini import ettik
            //koleksiyon.Add("emre");
            //koleksiyon.Add(1);
            //koleksiyon.Add(3.4);
            //bir koleksiyon hem string hem double hemde int değer alabiliyor ama biz istersek bunu özelleştirebiliriz yani generic list 


            //generic Listler
            /*List<int> rakamlar = new List<int>();
            rakamlar.Add(1);//artık sadece int değerleri alacaktır
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(6);
            rakamlar.Add(7);
            foreach( int i in rakamlar)
            {
                Console.WriteLine(i);
            }*/

            List<Musteri> musteriler = new List<Musteri>();
            musteriler.Add(new Musteri(1,"emre","almamış","ealö@gamil.com"));
            musteriler.Add(new Musteri(2, "ali", "reis", "ealö@gamil.com"));

            /*
            foreach (var musteri in musteriler) var otomatik olarak musteriler listesinin tipine göre değişiklik yapar yani illa tipini Musteri diye belirtmeye gerek yok
            {
                Console.WriteLine(musteri);
                

            }*/

            Console.WriteLine("toplam Müşteri: " + musteriler.Count);//toplma müşteri sayısını veriyor
            //musteriler.Clear();//tüm müşterileri siler
            //musteriler.RemoveAt(0);0 numaralı indisteki musteriyi siler

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri);

            }

            Console.ReadLine();
        }
    }
}

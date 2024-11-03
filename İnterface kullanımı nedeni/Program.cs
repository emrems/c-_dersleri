using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_kullanımı_nedeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* bir projemiz var ve birkaç farklı veritabanı ile çalışıyoruz. Her veritabanının kendi class içinde yazılmış kodları var. öyle bir controller yazmalıyız ki parametre olarak tüm veritabanlarını alabilsin.*/

            //interface'yi implemente eden classlardan oluştrulan örnekleri interface karşıayabilir. Aslında interface birden fazla tipi karşılar



            MusteriController musteriController = new MusteriController();
            musteriController.musteriEkle(new SqlServer());
            musteriController.musteriEkle(new MySql());
            Console.ReadLine(); 
        }
    }
}

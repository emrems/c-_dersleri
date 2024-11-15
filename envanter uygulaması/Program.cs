using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace envanter_uygulaması
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir mağazada farklı türdeki ürünleri (örneğin, gıda, elektronik, giyim) yönetmek istiyorsun. Her bir ürün türü için ayrı ayrı envanter yönetimi yapman gerekiyor, fakat aynı zamanda tüm ürünler üzerinde ortak işlemler (örneğin ürün ekleme, ürün kaldırma, listeleme) yapmalısın.*/

            Envanter<Giyim> giyimEnvanterleri = new Envanter<Giyim>();
            Giyim giyim1 = new Giyim("small");
            Giyim giyim2 = new Giyim("meedium");
            Giyim giyim3 = new Giyim("large");
            Giyim giyim4 = new Giyim("xxlarge");

            giyimEnvanterleri.Ekle(giyim1);

            giyimEnvanterleri.Ekle(giyim2);

            giyimEnvanterleri.Ekle(giyim3);

            giyimEnvanterleri.Guncelle(giyim1,giyim4);

            giyimEnvanterleri.sil(giyim2);

            giyimEnvanterleri.EnvanterleriListele();

            Console.ReadLine();
        }
    }
}

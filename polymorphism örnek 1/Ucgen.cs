using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek_1
{
    public class Ucgen:Sekil
    {
        public int tabanAlani { get; set; }
        public int yukseklik { get; set; }

        public Ucgen(string isim, int tabanAlani, int yukseklik) :base(isim)
        {
            this.tabanAlani = tabanAlani;
            this.yukseklik = yukseklik;
        }

        public override void sekilBilgileriGoster()
        {
            Console.WriteLine("şeklin ismi:" + getIsim());
            Console.WriteLine(getIsim() + "in taban alanı "+ this.tabanAlani);
            Console.WriteLine(getIsim() + "in yüksekliği " + this.yukseklik);
        }

        public override void sekilHesapla()
        {
            Console.WriteLine(getIsim() + "in alanı" + (this.tabanAlani*this.yukseklik)/2);
        }

    }
}

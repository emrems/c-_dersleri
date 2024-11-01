using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek_1
{
    public class Kare:Sekil
    {
        public int kenarUzunluğu {  get; set; }
        public Kare(string isim, int kenarUzunluğu) :base(isim)
        {
            this.kenarUzunluğu = kenarUzunluğu;
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
        }
        public override void sekilHesapla()
        {
            Console.WriteLine(getIsim() + "in alanı"+ this.kenarUzunluğu*this.kenarUzunluğu);
        }
    }
}

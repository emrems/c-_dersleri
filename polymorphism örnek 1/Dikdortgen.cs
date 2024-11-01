using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek_1
{
    public class Dikdortgen:Sekil
    {
        public int kisaKenar {  get; set; }
        public int uzunKenar { get; set; }
        public Dikdortgen(string isim, int kisaKenar, int uzunKenar) :base(isim) 
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar; 

        }
        public override void sekilHesapla()
        {
            Console.WriteLine(getIsim() + "nin alanı" + this.kisaKenar*this.uzunKenar);
        }
        public override void sekilBilgileriGoster()
        {
            base.sekilBilgileriGoster();
            Console.WriteLine(getIsim() + "in kısa kenarı" + this.kisaKenar + "uzun kenarı" + this.uzunKenar);
        }
    }
}

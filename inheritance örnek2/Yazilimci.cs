using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_örnek2
{
    public class Yazilimci: Calisan
    {
        private string  diller;
        public Yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim)/* :base ifadesi yazılımcı constructurundan aldığım parametreleri çalıisan sınıfındaki constructora gönder demek*/
        {

            this.diller = diller;

        }

        public void formatAt(string isletim_sistemi)
        {
            Console.WriteLine(getName() + "isimli yazilimci" + isletim_sistemi + "işletim sistemine format atmaktadır");
        }
    }
}

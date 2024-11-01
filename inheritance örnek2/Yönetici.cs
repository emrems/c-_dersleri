using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_örnek2
{
    public class Yönetici:Calisan
    {
        private int sorumluKisiSayisi;
        public Yönetici(int id, string isim, string soyisim, int sorumluKisiSayisi):base(id,isim,soyisim)      
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void zamYap(int zamMiktarı)
        {
            Console.WriteLine(getName() + " " + zamMiktarı + "kadar zam yapıyor");
        }
    }
}

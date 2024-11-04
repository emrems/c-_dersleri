using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeme_yöntemleri_uygulaması
{
    public class Siparis
    {
        public Odeme ödemeBilgisi {  get; set; }//Odeme tipinde bir property tanımladık

        public Siparis(Odeme odeme) //constructor parametre olarak odeme sınıfından bir nesne alıyor
        { 
            this.ödemeBilgisi = odeme;
        }

        public void siparisiTamamla()
        {
            ödemeBilgisi.dogrulama();
            ödemeBilgisi.odemeYap();
        }
    }
}

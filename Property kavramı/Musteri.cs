using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_kavramı
{
    public class Musteri
    {
        /*
        public int kilo;//burdaki kilo field'dir değişken de deniyor
        public int kilo2 { get; set; }//prop yazıp 2 kere tab yaparsam bu kalıp gelir

        // üstteki hali ile kilo ve kilo2 arasında bir fark yok. Çünkü kilo2 nin get ve set fonksiyonları kullanılmadı
        */


        private int kilo;

        public int KİLO
        {
            get
            {
                return kilo;
            }

            set
            {
                kilo = value;//value kullanıcının gireceği kilo değerini temsil eder.
            }
        
        }
    }
}

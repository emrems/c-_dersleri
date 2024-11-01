using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Hayvan
    {
        public string isim {  get; set; }
        public Hayvan(string isim)
        {
            this.isim = isim;   

        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }
        /* virtual anahtar kelimesi diğer miras alacak sınıfların bu methosu ezip içeriği değiştrilebilir demek*/
        public virtual void konus()
        {
            Console.WriteLine("hayvan konustu");
        }
    }
}

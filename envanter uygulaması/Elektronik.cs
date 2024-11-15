using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace envanter_uygulaması
{
    public class Elektronik
    {
        private double fiyat {  get; set; }
        private string urunNumarası {  get; set; }
        private string isim{ get; set; }
        private string marka {  get; set; }
        public Elektronik(double fiyat, string urunNumarası , string marka)
        {
            this.fiyat = fiyat;
            this.urunNumarası = urunNumarası;
            this.marka = marka;
        }

        public override string ToString()
        {
            return $"isim: {isim}";
        }
    }
}

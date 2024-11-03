using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internalinterface
{
    public class Musteri : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("muşteri eklendi");
        }

        public void getir()
        {

            Console.WriteLine("muşteri getirildi");
        }

        public void guncelle()
        {
            Console.WriteLine("muşteri guncellendi");
        }

        public void sil()
        {
            Console.WriteLine("muşteri silindi");
        }
    }
}

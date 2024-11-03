using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_kullanımı_nedeni
{
    public class MySql : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("MySql ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("MySql guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("MySql sildi");
        }
    }
}

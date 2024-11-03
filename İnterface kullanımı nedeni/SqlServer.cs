using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_kullanımı_nedeni
{
    public class SqlServer : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("sqlserver ekledi"); 
        }

        public void guncelle()
        {
            Console.WriteLine("sqlserver guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("sqlserver sildi");
        }
    }
}

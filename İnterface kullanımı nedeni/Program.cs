using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_kullanımı_nedeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriController musteriController = new MusteriController();
            musteriController.musteriEkle(new SqlServer());
            musteriController.musteriEkle(new MySql());
            Console.ReadLine(); 
        }
    }
}

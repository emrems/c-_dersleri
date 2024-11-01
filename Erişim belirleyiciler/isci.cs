using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_belirleyiciler
{
    public class isci
    {
        public int id = 1;
        public string isim = "emre";
        public string soyisim { get; set; }

        public void bilgileriGetir()
        {
            Console.WriteLine("işçi id" + id);
            Console.WriteLine("isim"+isim);
            Console.WriteLine("soyisim" + soyisim);
           

        }

        private void deneme()
        {
            Console.WriteLine("deneme");
        }
    }

}

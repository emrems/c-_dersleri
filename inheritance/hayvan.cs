using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class hayvan
    {
        public string hayvan_isim;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        private int hayvan_yasi;

        public void bilgileriGetir()
        {
            Console.WriteLine("hayvan ismi" + hayvan_isim);
            Console.WriteLine("hayvan cinsiyeti" + hayvan_cinsiyet);
        }
        
    }
}

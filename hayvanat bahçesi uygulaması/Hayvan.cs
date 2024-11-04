using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanat_bahçesi_uygulaması
{
    public abstract class Hayvan
    {
        private string name;

        public void setName(string name)
        {
            this.name = name;
        }
        public string  getName()
        {
            return name;
        }
        public void yemekYe()
        {
            Console.WriteLine("yemek yendi");
        }
        public abstract void sesCikar();
    }
}

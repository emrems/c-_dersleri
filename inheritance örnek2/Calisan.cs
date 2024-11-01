using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_örnek2
{
    public class Calisan
    {
        private int id;
        private string name;
        private string surname;
        public Calisan(int id, string isim, string soyisim)
        {
            this.id = id;
            this.name = isim;
            this.surname = soyisim;

        }

        public int getId() { return this.id; }
        public void setId(int id) { this.id = id; }

        public string getName() { return this.name; }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string soyisim)
        {
            this.surname = soyisim;
        }

        public string getSurname()
        {
            return this.surname;
        }
    }
}

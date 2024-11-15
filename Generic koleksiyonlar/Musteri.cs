﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_koleksiyonlar
{
    public class Musteri
    {
        public int id { get; set; }
        public string  isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }

        public Musteri(int id, string isim, string soyisim, string email)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.email = email;
            
        }
        public override string ToString()
        {
            return "id:"+ this.id+ " " + "isim: " +this.isim + "soyisim : " + this.soyisim;
        }
    }
}

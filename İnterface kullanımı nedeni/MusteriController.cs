using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_kullanımı_nedeni
{
    public class MusteriController
    {
        public void musteriEkle(IMusteri veritabani)
        {
            veritabani.ekle();
        }
    }
}

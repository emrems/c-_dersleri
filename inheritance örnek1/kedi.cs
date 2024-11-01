using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_örnek1
{
    public class kedi:kopek
    {
        public void sesCikar()
        {
            Console.WriteLine("kedi ses cıkarttu");
        }
        public void hayvanBilgileriGoster()
        {
            Console.WriteLine("hayvanın ismi: "+ hayvanİsmi);
            Console.WriteLine("hayvanın rengi: "+ hayvanRenk);
            Console.WriteLine("hayvanın kilosu :" + hayvanKilo);
            Console.WriteLine("hayvanın ayak sayısı:" + kopekAyakSayisi);
            Console.WriteLine("hayvanın cinsiyeti: " + kopekCinsiyet);


        }
    }
}

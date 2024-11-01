
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Kedi:Hayvan
    {
        public Kedi(string isim):base(isim) 
        {
            
        }
        /* override ile konus fonksiyonunu ezdik*/
        public override void konus()
        {
            Console.WriteLine(getIsim() + "miyavlıyor");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hayvanat_bahçesi_uygulaması
{
    public class Kus : Hayvan
    {
        public override void sesCikar()
        {
            Console.WriteLine(getName() + "cik sesi verdi");
        }
    }
}

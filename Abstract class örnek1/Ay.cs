using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_örnek1
{
    public abstract class Ay
    {
        public  int kacSaat()
        {
            return 24;//her gün 24 saattir

        }
        // her ayın yılın kaçıncı ayı olduğu ve kaç çektiği değişkenlik gösteriyor bu yüzden bu methodların imzasını attık kendi classlarında override edecceğiz
        public abstract int kacinciAy();
        public abstract int kacCekiyor();
        
    }
}

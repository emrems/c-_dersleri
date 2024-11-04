using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classlar
{
    public abstract class TemelSinif
    {
        public void metot1()
        {
            Console.WriteLine("metot1 çalışı");
        }
        public abstract void metot2();//burda gövdesi olmayan bir fonksiyon tanımladık abstrect sayesinde
    }
}

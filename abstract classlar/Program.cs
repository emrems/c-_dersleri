using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tamamen kalıtım amacıyla kullanılır
            //normal classları new anahtar kelimesi ile örnekleme yapılabilir ancak abstract classlarda yapılamaz
            //normal classlarda method gövdesi olmadan bırakılamaz ama abstract classlarda bıraklıbailri
            //kalıtım alındığı sınıfta implement edilmek zorunda
            AltSinif altSinif = new AltSinif();
            altSinif.metot1();
            altSinif.metot2();
        }
    }
}

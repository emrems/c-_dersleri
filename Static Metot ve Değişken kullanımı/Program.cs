using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Metot_ve_Değişken_kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
            {
                                                    //-----------STATİC METOT KULLANIMI---------------------

            //biz normalde bir class içindeki metota veya değişkene ulaşmak için yeni bir nesne türetiyorduk. Ama static olursa direkt class ismi üzerinden ulaşabilirsin
            //örnegin Console bir sınıftır, Readline() ise static metottur. Çünkü Consoole sınıfından nesne türetmeyiz direkt Console üzerinden erişebiliriz.

            Person.BilgileriGetir();
            Console.ReadLine();
        }
    }
}

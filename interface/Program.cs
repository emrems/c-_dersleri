using internalinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface içine kullanacağımız methodaları yazarız. Kalıtım aldığımız classlarda ise içeriğini doldururuz
            //interfaceyi nerde inheritance ettiysek orda interface içindeki tüm methodları doldurmam gerekir
            //bir class birden fazla interfaceden kalıtım alabilir
            Musteri musteri = new Musteri();
            musteri.ekle();
            musteri.getir();
            
            IMusteri musteri1 = new Musteri();//Musteri sınıfından oluştrulan örnek IMusteri tarafından karşılanabilir
            musteri1.getir();
            /*
            Bu şekilde bir interface'in bir örneğini oluştruamayız
            IMusteri musteri1 = new IMusteri();*/

            Console.ReadLine();


        }
    }
}

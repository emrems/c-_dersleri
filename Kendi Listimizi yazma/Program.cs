using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendi_Listimizi_yazma
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<String> myList = new MyList<string>();
            myList.Ekle("ds");
            myList.Ekle("fdşfs");
            myList.Ekle("fdfdfssfd");

            // listeyi temizle
            myList.Temizle();

            //yeni eleman ekle
            myList.Ekle("emre");
            myList.Ekle("ali");
            myList.Ekle("cemal");
            myList.Ekle("dede");


            Console.WriteLine(myList.Count);

            // elemanları gezme
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }


            // eleman kontrolu
            bool c = myList.VarMi("emre");
            Console.WriteLine(c);

            // elemanın indexini bulma
            int index = myList.IndexBul("dede");
            Console.WriteLine(index);
        }
    }
}

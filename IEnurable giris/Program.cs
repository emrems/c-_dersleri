using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnurable_giris
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MyList list = new MyList();
            //list.Add(1);
            //list.Add(2);
            //list.Add("emre");

            //   foreach(var item in list) // bu şekilde list içindeki elemanları gezebilmemizi MyList IEnramable den kalıtım aldığı için sağladı
            //   {
            //       Console.WriteLine(item);
            //   }

            //List<string> isimler = new List<string>();
            //isimler.Add("emre");
            //isimler.Add("ali");
            //foreach (var item in isimler)
            //{
            //    Console.Write(item);
            //}

            IEnumerable<string> isimler = new List<string>();
            isimler=isimler.Append("emre");
            isimler=isimler.Append("reis");

            foreach (string item in isimler) { 
                Console.WriteLine(item);
            }
            Console.ReadLine();




        }
    }
}

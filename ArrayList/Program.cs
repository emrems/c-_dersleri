using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylist bildiğimiz dizi gibidir.Her tipteki veriyi alır.
            List<string> koleksiyon = new List<string>();
            koleksiyon.Add("suna");
            
            koleksiyon.Add("mahmut");

            for(int i=0; i<koleksiyon.Count; i++)
            {
                Console.WriteLine(koleksiyon[i]);
            }

            koleksiyon.Remove("suna");
            for (int i = 0; i < koleksiyon.Count; i++)
            {
                Console.WriteLine(koleksiyon[i]);
            }
            Console.ReadLine();

        }
    }
}

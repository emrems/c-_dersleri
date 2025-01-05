using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class_mantığı_anlama
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> list = new Mylist<string>();
            list.Ekle("mus");
            list.Ekle("fdfd");
            list.Ekle("dsds");
            Console.WriteLine(list.Count);
            

            
        }
    }

    class Mylist<T>
    {
        T[] _array;
        public int Count { get { return _array.Length; } }

        public Mylist()
        {
            _array = new T[0];
        }

        public void Ekle(T item)
        {
            _array = new T[_array.Length+1];
            _array[0] = item;
        }


    }
}

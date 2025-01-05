using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendi_Listimizi_yazma
{
    public class MyList<T> : IEnumerable<T>
    {
        public int Count { get { return _array.Length; } }


        T[] _array;
        T[] _TempArray;

        public MyList()
        {
            _array = new T[0];//başlangıçta 0 elemanlı bir array nesnesi oluşturuyorum

        }

        public void Ekle(T item)
        {
            _TempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i=0; i<_TempArray.Length; i++)
            {
                _array[i]= _TempArray[i];
            }
            _array[_array.Length - 1] = item;

        }

        public bool VarMi(T item)
        {
            for(int i=0; i<_array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                 
                    return true;
                }

            }
            return false;
        }

        public  int IndexBul(T item)
        {
            for(int i=0; i<_array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Temizle()
        {
            _array = new T[0];
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i =0; i<_array.Length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }





        //public int Count()
        //{
        //    return _array.Length;
        //}


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnurable_giris
{
    public class MyList : IEnumerable
    {
        public ArrayList array;

        public MyList()
        {
            array = new ArrayList();
        }

        public void Add(object value)
        {
            array.Add(value);
        }

        public void Clear()
        {
            array.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}

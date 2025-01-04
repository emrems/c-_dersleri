using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_örnek
{
    public class MockRepository : IDataRepository
    {
        public string GetData()
        {
            return "test datası geldi";
        }
    }
}

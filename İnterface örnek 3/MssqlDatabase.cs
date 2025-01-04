using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_örnek_3
{
    public class MssqlDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("mssaql added");
        }

        public void Delete()
        {
            Console.WriteLine("mssaql deleted");
        }

        public void Update()
        {
            Console.WriteLine("mssaql uptaded");
        }
    }
}

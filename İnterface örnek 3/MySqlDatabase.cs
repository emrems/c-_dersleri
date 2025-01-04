using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_örnek_3
{
    public class MySqlDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("mysql addded");
        }

        public void Delete()
        {
            Console.WriteLine("mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("mysql updated");
        }
    }
}

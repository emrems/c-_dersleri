using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_örnek_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            IDatabase[] db = new IDatabase[] {  new MssqlDatabase(), new MySqlDatabase()};
            foreach(var dbItem in db)
            {
                ServiceManager manager = new ServiceManager(dbItem);
                manager.Add();
                manager.Update();
                manager.Delete();
            }
        }
    }
}

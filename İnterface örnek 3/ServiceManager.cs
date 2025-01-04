using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_örnek_3
{
    public class ServiceManager
    {
        private IDatabase _database;
        public ServiceManager(IDatabase database)
        {
            _database = database;
        }

        public void Add()
        {
            _database.Add();
        }
        public void Delete() 
        {
            _database.Delete();
        }

        public void Update()
        {
            _database.Update();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_ile_Dependency_injection_ilişkisi
{
    public class CustomerService : ICustomerService
    {
        public void AddPerson(string name, string surname)
        {
            Console.WriteLine($"{name} {surname} isimli müşteri başarıyla eklendi ");
        }
    }
}

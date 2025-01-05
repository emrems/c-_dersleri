using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_ile_Dependency_injection_ilişkisi
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerOperation customerOperation = new CustomerOperation(new CustomerService());//CustomerOperation parametre olarak ICustomerService'nin implemente edildiği bir sınıf bekliyor
            //CustomerService ICustomerService den kalıtım aldığı için aslında ICustomerService tipine dönüştü
            customerOperation.AddPerson("emre", "almamış");
        }
    }
}

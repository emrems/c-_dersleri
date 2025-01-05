using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_ile_Dependency_injection_ilişkisi
{
    public class CustomerOperation
    {
        private readonly ICustomerService _customerService;
        public CustomerOperation(ICustomerService customerService)
        {
            _customerService = customerService;   
        }

        public void AddPerson(string name, string surname)
        {
            _customerService.AddPerson(name, surname);
        }
    }
}

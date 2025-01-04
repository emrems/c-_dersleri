using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_örnek
{
    public class ProductService
    {
        public IDataRepository _repository;

        public ProductService(IDataRepository repository)
        {
            _repository = repository;
            
        }

        public string GetData()
        {
            return _repository.GetData();
        }
    }
}

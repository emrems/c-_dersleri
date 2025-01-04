using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_örnek
{
    public class Program
    {
        static void Main(string[] args)
        {
            public interface IDataRepository
        {
            string GetData();
        }

        public class ProductService
        {
            private readonly IDataRepository _repository;

            public ProductService(IDataRepository repository)
            {
                _repository = repository;
            }

            public string GetProductData()
            {
                return _repository.GetData();
            }
        }

        // Birim Test
        public class MockRepository : IDataRepository
        {
            public string GetData()
            {
                return "Test Data";
            }
        }

    }
}
}

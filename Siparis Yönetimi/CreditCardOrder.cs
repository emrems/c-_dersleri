using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Yönetimi
{
    public class CreditCardOrder : Order
    {
        private string CardName {  get; set; }
        private string Name { get; set; }
        public override void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}

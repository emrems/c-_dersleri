using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Yönetimi
{
    public class BankTransferOrder : Order
    {
        private string BankName { get; set; }
        private string HesapNo{ get; set; }
        public override void ProcessPayment()
        {
            throw new NotImplementedException();
        }
    }
}

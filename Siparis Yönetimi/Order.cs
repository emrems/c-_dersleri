using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Yönetimi
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }

        public abstract void ProcessPayment();//öödeme şeklini almak için
    }
}

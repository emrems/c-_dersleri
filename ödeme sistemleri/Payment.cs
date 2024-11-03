using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ödeme_sistemleri
{
    public class Payment
    {
        private string name {  get; set; }
       
        public virtual void makePayment(decimal amount)
        {
            Console.WriteLine("ödeme işlemi gerçekleştriliyor");
        }

        public string getname(string name)
        {
            if (name == null)
            {
                return null;
            }
            else
            {
                return name;
            }
        }

        public void setName(string name)
        {
            this.name = name;
        }
        
       
    }
}

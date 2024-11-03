using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödeme_sistemleri
{
    public class CreditCardPayment:Payment
    {
        private string creditCardNo;


        public void setCreditCardNo(string creditCardNo)
        {
            this.creditCardNo = creditCardNo;
        }

        public string getCreditCardNo()
        {
            if (this.creditCardNo.Length == 5)
            {
                return this.creditCardNo;
            }
            else
            {
                return null;
            }
        }
        public override void makePayment(decimal amount)
        {
            Console.WriteLine("card sahibi ismini giriniz");
            string name = Console.ReadLine();
            setName(name);
            if(getname(name)==null || name.Length==0)
            {
                Console.WriteLine("kart sahibi ismi boş geçilemez!!!");
            }
            else
            {
                if (!string.IsNullOrEmpty(getCreditCardNo()))
                {
                    Console.WriteLine(getname(name)+"adlı kullanıcının"+ getCreditCardNo() + "numaralı kartından" + amount + "tl" + "ödeme çekiliyor");
                }
                else
                {
                    Console.WriteLine("ödeme işlemi başarısız.geçerli bir kart numarası giriniz");
                }
            }
            
            
        }
    }
}

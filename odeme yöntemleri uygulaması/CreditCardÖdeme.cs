using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeme_yöntemleri_uygulaması
{
    public class CreditCardÖdeme:Odeme
    {
        private string cardNo;

        public override void odemeYap()
        {
            if(string.IsNullOrEmpty(cardNo))
            {
                Console.WriteLine("ödeme yapılamaz");
            }
            else
            {

                Console.WriteLine(getCardNo() + "numaralı kredi kartı ile ödeme yapılıyor");
            }
        }

        public bool setCardNo(string cardNo)
        {
            if(string.IsNullOrEmpty(cardNo) || cardNo.Length != 3)
            {
                Console.WriteLine("card numarasını doğru formatta girniz");
                return false;
                
            }
            else
            {
                this.cardNo = cardNo;
                return true;
            }
        }
        public string getCardNo()
        {
            return this.cardNo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeme_yöntemleri_uygulaması
{
    public class HesapİleOdeme : Odeme
    { 
        public string ibanNo{ get; set; }
        public override void odemeYap()
        {
            Console.WriteLine("ödeme hesaba iban ile atılıyor");
        }

        public bool Setİban(string iban)
        {
            if(string.IsNullOrEmpty(iban) || iban.Length != 4)
            {
                Console.WriteLine("yanlış iban girişi");
                return false;
            }
            else
            {
                this.ibanNo = iban;
                return true;
            }
        }
    }
}

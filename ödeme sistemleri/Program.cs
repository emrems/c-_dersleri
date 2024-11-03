using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödeme_sistemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-credi kartı");
                Console.WriteLine("2-nakit");
                Console.WriteLine("3-çıkış");
                Console.WriteLine("hangi ödeme yöntemini tercih edersiniz");
                string secim = Console.ReadLine();

                if(secim == "3")
                {
                    Console.WriteLine("çıkış yapılıyor");
                    break;
                }
                else if(secim == "1")
                {
                    Console.WriteLine("credi kartı yöntemini seçtiniz");

                    CreditCardPayment card = new CreditCardPayment();
                    Console.WriteLine("lütfen kredi kartı numaranızı giriniz");
                    string cardNo= Console.ReadLine();
                    card.setCreditCardNo(cardNo); 
                    card.makePayment(20);
                }
                else if(secim == "2")
                {
                    Console.WriteLine("nakit ödeme yöntemini seçtiniz");
                    Nakit nakit_odeme = new Nakit();
                    nakit_odeme.makePayment(20);
                }
                else
                {
                    Console.WriteLine("lütfen geçerli bir işlem yapınız");
                }
            }


            
        }
    }
}

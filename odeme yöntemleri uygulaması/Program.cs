using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeme_yöntemleri_uygulaması
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("sipariş verme uygulamasına hoşgeldiniz.Lütfen ödeme yöntemini seçiniz");
                Console.WriteLine("1-kredi kartı");
                Console.WriteLine("2-nakit ödeme");
                Console.WriteLine("3-hesaba atma");
                Console.WriteLine("4-çıkış");

                string odemeSecimi = Console.ReadLine();
                if (odemeSecimi == "q") break;
                else if(odemeSecimi == "1")
                {
                    Console.WriteLine("kredi kartı ile ödeme yöntemini seçtiniz");
                   
                   
                    CreditCardÖdeme credi = new CreditCardÖdeme();
                    while (true)
                    {

                        Console.Write("lütfen 3 haneli kredi kartı numarasını giriniz");
                        string cardNo = Console.ReadLine();
                        Console.Write("lütfen 5 haneli tc kimlik numarasını giriniz");
                        string tc = Console.ReadLine();
                        if (credi.setCardNo(cardNo) && credi.setTc(tc))
                        {
                            break;
                        }
                    }

                    Siparis siparis1 = new Siparis(credi);
                    siparis1.siparisiTamamla();
                }
                else if(odemeSecimi == "2")
                {
                    Console.WriteLine("nakit ödeme yöntemini seçtiniz");
                    Nakit nakit = new Nakit();
                    Siparis siparis2 = new Siparis(nakit);
                    while (true)
                    {
                        Console.WriteLine("lütfen 5 haneli tc kimlik numaranızı giriniz");
                        string tc = Console.ReadLine();
                        if (nakit.setTc(tc))
                        {
                            break;
                        }   
                        
                    }
                    siparis2.siparisiTamamla();

                }
                else if(odemeSecimi == "3")
                {
                    Console.WriteLine("ödeme yöntemini hesaba atma olarak seçtiniz");
                    HesapİleOdeme hesapOdeme = new HesapİleOdeme();
                    Siparis siparis3 = new Siparis(hesapOdeme);

                    while (true)
                    {
                        Console.WriteLine("5 haneli tc kimlik numaranızı giriniz");
                        string tc = Console.ReadLine();

                        Console.WriteLine("4 haneli iban numaranzı giriniz");
                        string iban = Console.ReadLine();

                        if(hesapOdeme.setTc(tc) && hesapOdeme.Setİban(iban))
                        {
                            break;
                        }
                    }
                    siparis3.siparisiTamamla();

                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_örnek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("şekil uyguşamsına hosgeldiniz");

            while (true)
            {
                Console.WriteLine("1-dikdörgen işlemleri");
                Console.WriteLine("2-kare işlemleri");
                Console.WriteLine("3-üçgen işlemleri");
                Console.WriteLine("çıkış için q ya bas");
                Console.WriteLine("yapmak istediğiniz işlemi seçiniz");
                string secim = Console.ReadLine();

                if (secim == "q")
                {
                    Console.WriteLine("uygulamadan çıkış yapılıyor");
                    break;
                }
                else if (secim == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("dikdörgen işlemlerini seçtiniz");

                        Console.WriteLine("1-kenar uzunluklarını öğrenme");
                        Console.WriteLine("2-alanını öğrenme");
                        Console.WriteLine("dikdörtgen işlemlerinden çıkış için q ya basınız");
                        Console.WriteLine("dikdörtgen işlemlerinden hangisini yapmak istiyorsunuz? lütfen bir seçim yapınız");
                        Dikdortgen dikdortgen = new Dikdortgen("dikdörtttgen", 4, 5);
                        string dikdortgenSecim = Console.ReadLine();
                        if (dikdortgenSecim == "q")
                        {
                            Console.WriteLine("çıkış yapılıyor");
                            break;
                        }
                        else if (dikdortgenSecim == "1")
                        {
                            Console.WriteLine(dikdortgen.getIsim());
                            Console.WriteLine(dikdortgen.uzunKenar);
                            Console.WriteLine(dikdortgen.kisaKenar);

                        }
                        else if (dikdortgenSecim == "2")
                        {
                            dikdortgen.sekilHesapla();
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli bir işlem giriniz");
                        }
                    }

                }
                else if (secim == "2")
                {
                    Console.WriteLine("kare işlemlerini seçtiniz");
                    while (true)
                    {
                        Console.WriteLine("1-kenar uzunluklarını öğrenme");
                        Console.WriteLine("2-alanını öğrenme");
                        Console.WriteLine("kare işlemlerinden çıkış için q ya basınız");
                        Console.WriteLine("kare işlemlerinden hangisini yapmak istiyorsunuz? lütfen bir seçim yapınız");
                        Kare kare = new Kare("kare", 8);
                        string kareSecim = Console.ReadLine();
                        if (kareSecim == "q")
                        {
                            Console.WriteLine("çıkış yapılıyor");
                            break;
                        }
                        else if (kareSecim == "1")
                        {
                            Console.WriteLine(kare.getIsim());
                            Console.WriteLine(kare.kenarUzunluğu);

                        }
                        else if (kareSecim == "2")
                        {
                            kare.sekilHesapla();
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli bir işlem giriniz");
                        }
                    }
                }
                else if (secim == "3")
                {
                    Console.WriteLine("üçgen işlemlerini seçtiniz");
                    while (true)
                    {
                        Console.WriteLine("1-kenar uzunluklarını öğrenme");
                        Console.WriteLine("2-alanını öğrenme");
                        Console.WriteLine("üçgen işlemlerinden çıkış için q ya basınız");
                        Console.WriteLine("üçgen işlemlerinden hangisini yapmak istiyorsunuz? lütfen bir seçim yapınız");
                        Ucgen ucgen = new Ucgen("üçgen", 8, 4);
                        string ucgenSecim = Console.ReadLine();
                        if (ucgenSecim == "q")
                        {
                            Console.WriteLine("çıkış yapılıyor");
                            break;
                        }
                        else if (ucgenSecim == "1")
                        {
                            Console.WriteLine(ucgen.tabanAlani);
                            Console.WriteLine(ucgen.yukseklik);

                        }
                        else if (ucgenSecim == "2")
                        {
                            ucgen.sekilHesapla();
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli bir işlem giriniz");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("lütfen uygulama içinden doğru bir giriş yapınız");
                }
            }
        }
    }
}
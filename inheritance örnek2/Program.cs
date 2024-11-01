using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_örnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("1-Yazılımcı işlemleri");
                Console.WriteLine("2-Yönetici işlemleri");
                Console.WriteLine("Çıkış için q bas");

                string secilenİslem = Console.ReadLine();
                if (secilenİslem == "q")
                {
                    Console.WriteLine("çıkış yapılıyor");
                    break;
                }
                else if(secilenİslem == "1")
                {
                    Console.WriteLine("yazılımcı işlemleri");
                    Yazilimci yazilimci = new Yazilimci(1,"emre","almamış","python,javascript");
                   

                    while (true)
                    {
                        Console.WriteLine("yazılımcı işlemleri seçiniz");
                        Console.WriteLine("1-format at");
                        Console.WriteLine("2-yazılımcının bilgilerini göster");
                        Console.WriteLine("çıkış yapmak için q ya basınız");
                        string secim = Console.ReadLine();
                        if (secim == "q")
                        {
                            /* burayı kırınca ana menüye geri dönecek*/
                            Console.WriteLine("yazılımcı işlem bölümümden çıkış yapılıyor");
                            break;
                        }
                        else if(secim == "1")
                        {
                            Console.Write("lütfen işletim sistemini giriniz");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if(secim == "2")
                        {
                            Console.WriteLine("yazılımcının ismi" + yazilimci.getName());
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli bir işlem seçiniz");
                        }
                    }
                }
                else if(secilenİslem == "2")
                {
                    Console.WriteLine("yönetici işlemlerine hoşgeldiniz");
                    Yönetici yönetici = new Yönetici(2, "suna", "çelik", 4);
                    
                    while (true)
                    {
                        Console.WriteLine("Yönetici işlemleri seçiniz");
                        Console.WriteLine("1-zam yap");
                        Console.WriteLine("2-yöneticinin bilgilerini göster");
                        Console.WriteLine("çıkış yapmak için q ya basınız");
                        string yöneticiSecim = Console.ReadLine();
                        if (yöneticiSecim == "q")
                        {
                            Console.WriteLine("yönetici islemlerinden çıkış yapılıyor");
                            break;
                        }    
                        else if(yöneticiSecim == "1")
                        {
                            Console.WriteLine("zam yapma kısmına hoşgeldiniz");
                            Console.Write("zam miktarı giriniz");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            yönetici.zamYap(zamMiktari);
                        }
                        else if(yöneticiSecim=="2")
                        {
                            Console.WriteLine("yönetici bilgileri göster kısmına hoşgeldiniz");
                            Console.WriteLine("yönetici ismi: " + yönetici.getName());
                            Console.WriteLine("yönetici soyismi " + yönetici.getSurname());
                        }
                        else
                        {
                            Console.WriteLine("lütfen geçerli bir işlem giriniz");
                        }
                    }
                }
                else{
                    Console.WriteLine("ütfen çalışan uygulaması için geçerli bir işlem gir");
                }
            }
        }
    }
}

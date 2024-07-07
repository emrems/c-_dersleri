using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme_pratik
{
    internal class Personel
    {
        private string tc;

        public string TC//prop yazıp 2 kere tab yapınca geliyor ama ismini genelde değiştiriyorsun
        {
            get
            {
                if(tc!=null && tc.Length >= 4)
                {
                
                    return tc.Substring(0, 5)+"******";
                }
                else
                {
                    return string.Empty;
                } 
            }

            set
            {
                if (value.Length == 11)
                {
                    bool kontrol = false;

                    for(int i = 0; i<value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {
                            //sıkıntı yok
                        }
                        else
                        {
                            kontrol = true;
                            break;//eğer bir tane harf görürse döngüyü  kır
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("tc kimlik sadece sayılardan oluşmalı");
                    }
                    else
                    {
                        tc = value;
                    }
                }
                else
                {
                    Console.WriteLine("lütfen 11 haneli olmalı");
                }
            }

        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odeme_yöntemleri_uygulaması
{
    public abstract class Odeme
    {
        private string tc;
        private string name;

        public string getTc()
        {
            return this.tc;
        }
        public bool setTc(string tc)
        {
            if (string.IsNullOrEmpty(tc) || tc.Length != 5)
            {
                Console.WriteLine("lütfen tc'yi doğru bir şekilde giriniz");
                return false;
               
            }
            else
            {
                this.tc = tc;
                return true;
            }
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void dogrulama()
        {
            Console.WriteLine("doğrulama yapıldı");
        }
        public abstract void odemeYap();//bu fonksiyonun imzası çağırılan classlarda farklı işlemleri yapcak
    }
}
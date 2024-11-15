using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class Repository<T>//classı generic olarak tanımladım. T gördüğü her yere mainde parametre olarak verdiğim şeyi yazacak müsteri ise urun ise Mesela personel tipinde verirse geitr metodu persoel tipinde dönencek. işşçi tipinde verirse getir metodu işçi tipinde dönececk. Aslında biz dinamikklik kattık
    {
        // veritabanı ile etkileşimde olacaksa genelde classa repository ismi verilir
        public List<T> Getir()//musteri,urun tipinde listeler donecek
        {
            //veritabanına git ilgili tablodan verileri çek ve kayıtları getir
            return null;
        }
        public string ekle(T data)
        {
            //veritbanına git ve T tippindeki datayı ilgili tabloya ekle
            return "data başarılı bir şekilde eklenmiştir";
        }
    }
}

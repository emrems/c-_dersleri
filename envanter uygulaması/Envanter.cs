using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace envanter_uygulaması
{
    public class Envanter<T>
    {
        private List<T> envanterListesi = new List<T>();
        public void Ekle(T data)
        {
            if (data == null)
            {
                Console.WriteLine("eklencek data bulunmadı");
            }
            else
            {
                envanterListesi.Add(data);
                Console.WriteLine("data başarılı bir şekilde eklendi");
            }
        }
        public void sil(T data)
        {
            if (envanterListesi.Contains(data))//liste içinde varsa true dönecek
            {
                envanterListesi.Remove(data);
                Console.WriteLine($"{data} silindi");
            }
            else
            {

                Console.WriteLine("silinecek data bulunamadı");
            }
        }

        public void Guncelle(T eskiData , T yeniData)
        {
            int index = envanterListesi.IndexOf(eskiData);///eğer eleman dizide yoksa geriye -1 döner     
            if(index == -1)
            {
                Console.WriteLine("guncellenecek veri bulunamadı");
            }
            else
            {
                envanterListesi[index] = yeniData;
                Console.WriteLine("güncelleme işlemi başarılı bir şekilde gerçekleşti");
            }
        }

        public void EnvanterleriListele()
        {

            if(envanterListesi.Count==0)
            {
                Console.WriteLine("listelenecek data bulunamadı");
               
            }
            else
            {
                foreach (var item in envanterListesi)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}

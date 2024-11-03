using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internalinterface
{
    public interface IMusteri
    {
        /* interface içine method tanımlarız. Erişim belirleyicisi olmaz(public,private gibi) ve bodysi sahip olmaz(yani süslül paranteler olmaz iççine bir şeyler yazılmaz)*/
        void ekle();
        void sil();
        void guncelle();
        void getir();

    }
}

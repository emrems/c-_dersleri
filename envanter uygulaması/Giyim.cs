using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace envanter_uygulaması
{
    public class Giyim
    {
        private string Beden { get; set; }

        public Giyim(string beden)
        {
            this.Beden = beden;
        }
        public override string ToString()
        {
            return $"Giyim: {Beden}";
        }

    }
}

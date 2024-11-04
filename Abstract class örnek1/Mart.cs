using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_örnek1
{
    public class Mart : Ay
    {
        public override int kacCekiyor()
        {
            return 30;
        }

        public override int kacinciAy()
        {
            return 3;
        }
    }
}

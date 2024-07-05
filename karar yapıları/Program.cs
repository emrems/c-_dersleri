using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int puan = 48;

            if (puan > 43)
            {
                Console.WriteLine("aferin");
            }
            if(puan > 34)
            {
                Console.WriteLine("bu da olur");
            }
            else
            {
                Console.WriteLine("olmaz");
            }
            */



            /*************************************************************/

            Console.WriteLine("lütfen ilk notunuzu giriniz");

            int one_note = Convert.ToInt32(Console.ReadLine());//alınan string değeri int'e çeviriyorum

            int second_note = Convert.ToInt32(Console.ReadLine());

            int third_note = Convert.ToInt32(Console.ReadLine());

            int total_grade = (one_note + second_note + third_note) / 3;

            if (total_grade >= 80 && total_grade <= 100)
            {
                Console.WriteLine("notunuz :A" + total_grade + "ile");

            }
            else if (total_grade >= 60 && total_grade <= 79)
            {
                Console.WriteLine("notunuz B" + total_grade + "ile");

            }
            else if (total_grade >= 40 && total_grade <= 59)
            {
                Console.WriteLine(" notunuz C" + total_grade + "ile");
            }
            else
            {
                Console.WriteLine("notunuz D" + total_grade + "ile");
            }


















            Console.ReadLine();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeSimple
{
    class PunctulTrei
    {
        public void RezolvarePunctulTrei()
        {
            Console.WriteLine("Introduceti primul numar");

            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");

            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a}; {b}");
            }
            else
            {
                Console.WriteLine($"{b}; {a}");
            }
        }
    }
}

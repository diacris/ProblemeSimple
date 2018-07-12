using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeSimple
{
    class PunctulPatru
    {
        public void RezolvarePunctulPatru()
        {
            Console.WriteLine("Introduceti primul numar");

            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");

            var d = Convert.ToInt32(Console.ReadLine());

            if (c > d)
            {
                Console.WriteLine($"{c + d}; {c - d}; {c * d} ; {c / d}");
            }
            else
            {
                Console.WriteLine($"{d + c}; {d - c}; {d * c}; {d / c}");
            }
        }
    }
}


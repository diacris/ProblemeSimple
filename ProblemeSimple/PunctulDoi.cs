using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeSimple
{
    class PunctulDoi
    {
        public void RezolvarePunctulDoi()
        {
            Console.WriteLine("Introduceti primul numar intreg");

            int primulNumar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar intreg");

            int alDoileaNumar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Rezultatul diviziunii lor este { primulNumar / alDoileaNumar}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            Console.WriteLine("Diana Vasile");

            PunctulDoi punctulDoi = new PunctulDoi();
            punctulDoi.RezolvarePunctulDoi();

            PunctulTrei punctulTrei = new PunctulTrei();
            punctulTrei.RezolvarePunctulTrei();

            PunctulPatru punctulPatru = new PunctulPatru();
            punctulPatru.RezolvarePunctulPatru();

            Console.ReadKey();
        }
    }    
}

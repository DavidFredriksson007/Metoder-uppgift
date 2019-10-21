using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
         public static void Main()
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
            Console.WriteLine("Cirkelns area: " + CirkelArea(radie));
        }

        static double CirkelOmkrets(double radie)
        {

            return (radie + radie) * (3.14);
        }

        static double CirkelArea(double radie)
        {

            return (radie * radie * 3.14);
 
        }
        
    } 

}


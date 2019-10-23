using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder3
{
    class Program
    {
        public static void Main()
        {
            int a = 10, b = 20;
            BytPlats(ref a, ref b);
            Console.WriteLine(a +" "+ b);
           
            
        }

        public static void BytPlats(ref int a, ref int b)
        {
            a = 20;
            b = 10;
      

            
        }



    }
}

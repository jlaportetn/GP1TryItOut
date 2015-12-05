using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg44
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine("17/4 is " + quotient + " remainder " + remainder);
            {
                Console.ReadKey();
            }
        }
    }
}

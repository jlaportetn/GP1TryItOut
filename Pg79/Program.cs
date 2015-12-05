using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg79
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number < 101; number++)
            {
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg78
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int height = 0; height <= 5; height++)
            {
                for (int space = 0; space <= 5 - height; space++)
                {
                    Console.Write(" ");
                }
                {
                    for (int width = 0; width <= height * 2; width++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg43
{
    class Program
    {
        static void Main(string[] args)
        {
            float triangleBASE = 5f;
            float triangleHeight = 6f;
            float triangleArea = triangleBASE * triangleHeight / 2;
            Console.WriteLine("The area of the triangle is " + triangleArea + ".");
            {
                Console.ReadKey();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cylinder Calculator!"); //Welcome message
            Console.WriteLine("Enter the cylinder's radius: "); //Ask for user input
            string radiusAsAString = Console.ReadLine();  //Create string based on user input
            double radius = Convert.ToDouble(radiusAsAString);  //Convert the string to a double

            Console.WriteLine("Enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsAString);

            double pi = 3.14592654;  //Assign value to var pi

            double volume = pi * radius * radius * height;  //Create double using volume formula

            double surfaceArea = 2 * pi * radius * (radius + height);  //Create double using surface area formula

            Console.WriteLine("The cylinder's volume is " + volume + " cubic units.");  //Display volume results to user
            Console.WriteLine("The cylinder's surface are is " + surfaceArea + " square units.");  //Same for surface A

            Console.ReadKey();  //Wait for user response before closing
        }
    }
}

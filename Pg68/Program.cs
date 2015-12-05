using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Positive or Negative 1.0!");
            Console.WriteLine("Please enter a positive or negative number.");

            string firstNumberAsText = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberAsText);

            Console.WriteLine("please enter another positive or negative number.");
            string secondNumberAsText = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberAsText);

            int answer = firstNumber * secondNumber;

            if (answer >= 0)
            {
                Console.WriteLine("Multiplying " + firstNumber + " by " + secondNumber + " will result in a positive.");
            }
            else
            {
                Console.WriteLine("Multiplying " + firstNumber + " by " + secondNumber + " will result in a negative.");
            }
            Console.ReadKey();
        }

    }
}

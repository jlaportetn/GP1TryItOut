using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator 1.0!");
            Console.WriteLine("Plese enter desired function: +, -, *, / or %");
            var function = Console.ReadLine();

            Console.WriteLine("Please enter your first number");
            decimal number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("please enter your second number");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());


            switch (function)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
                case "%":
                    Console.WriteLine(number1 % number2);
                    break;
                default:
                    Console.WriteLine("The function yoou entered is not valid.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

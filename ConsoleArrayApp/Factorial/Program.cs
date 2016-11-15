using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            int result = factorial(number);
            Console.WriteLine("Factorial of a number is :" + result);
            Console.ReadLine();
        }

        private static int factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }
    }
}

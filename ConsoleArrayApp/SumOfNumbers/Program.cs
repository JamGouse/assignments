using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input = null;
            int number = 0;
            int index = 0;
            int[] numbers = new int[100];
            do
            {
                Console.WriteLine("Enter a number :");
                input = Console.ReadLine();
                bool result = int.TryParse(input, out number);
                if (result)
                {

                    numbers[index] = number;
                    ++index;
                    sum = sum + number;
                    Console.WriteLine("Sum :" + sum);
                }
            } while (input != "end");
            Console.Write("The numbers are :");
            for (int i = 0; i < index; i++)
            {
                Console.Write("{0}\t", numbers[i]);
            }

            Console.WriteLine("\nThe Sum is :" + sum);
            Console.ReadLine();
        }
    }
}

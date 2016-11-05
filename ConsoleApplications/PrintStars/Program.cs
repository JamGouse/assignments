using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
                Console.Write("Enetr a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                for (int i = number; i >= 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("\nDo you want to continue? press(y/n)...");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

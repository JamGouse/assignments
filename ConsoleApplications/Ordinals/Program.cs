using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinals
{
    class Program
    {
        public static int rightMostDigit, modOfHundrad, modOfTen;
        public static string suffix = null;

        static void Main(string[] args)
        {
            string choice = null;
            do
            {
                Console.Write("Enter a number :");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                suffix = getOrdinals(number);
                Console.WriteLine("That's the " + number + suffix + " item!");
                Console.WriteLine("\nDo you want to continue? press(y/n)...");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");

        }

        //getOrdinal : takes a number and returns
        //a string as suffix for the number
        public static string getOrdinals(int number)
        {
            int modoften = number % 10;

            int rightMostDigit = modOfTen;

            if (rightMostDigit == 1 || rightMostDigit == 2 || rightMostDigit == 3)
            {
                int modOfHundrad = number % 100;
                if (modOfHundrad == 11 || modOfHundrad == 12 || modOfHundrad == 13)
                {
                    return (suffix = "th");
                }
            }

            if (modOfTen == 1)
            {
                suffix = "st";
            }
            else if (modOfTen == 2)
            {
                suffix = "nd";
            }
            else if (modOfTen == 3)
            {
                suffix = "rd";
            }
            return (suffix);
        }
    }
}

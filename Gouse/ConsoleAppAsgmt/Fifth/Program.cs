using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
            Console.WriteLine("Please press any number key");
            string key = Console.ReadLine();
            Regex r = new Regex(@"^\d{1}");
            bool result = r.IsMatch(key);
            if (result)
                Console.WriteLine("You have pressed :" + key);
            //if (key == "0" || key == "1" || key == "2" || key == "3" || key == "4" || key == "5" || key == "6" || key == "7" || key == "8" || key == "9")
            //    Console.WriteLine("You have pressed :" + key);
            else
                Console.WriteLine("Not allowed");
            Console.WriteLine("\nDo you want to continue? press(y/n)...");
            choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

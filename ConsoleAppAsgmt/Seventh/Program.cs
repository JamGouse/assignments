using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
            Console.Write("Enter a number :");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int mod = no % 10;
            if(mod==1)
                Console.WriteLine("That's the "+no+ "st item!");
            else if(mod==2)
                Console.WriteLine("That's the "+no+ "nd item!");
            else if (mod == 3)
                Console.WriteLine("That's the " + no + "rd item!");
            else 
                Console.WriteLine("That's the " + no + "th item!");
            Console.WriteLine("\nDo you want to continue? press(y/n)...");
            choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

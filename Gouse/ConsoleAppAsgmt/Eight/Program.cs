using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eight
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
            Console.Write("How many items do you want to see? ");
            int items = int.Parse(Console.ReadLine());
            for(int i=1; i<=items; i++)
            {
                int divbythree = i % 3;
                int divbyfive = i % 5;
                if (divbythree == 0 && divbyfive == 0)
                {
                    Console.WriteLine("foobar");
                }
                else if (divbythree == 0)
                {
                    Console.WriteLine("foo");
                }
                else if (divbyfive==0)
                {
                    Console.WriteLine("bar");
                }
                else
                    Console.WriteLine(i);
            }
            Console.WriteLine("\nDo you want to continue? press(y/n)...");
            choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

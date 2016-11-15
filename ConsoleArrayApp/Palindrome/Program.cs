using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = null;
            Console.Write("Enter a string :");
            string name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse = reverse + name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine("\nEntered string " + name + " is palindrome ");
            }
            else
            {
                Console.WriteLine("\nEntered string " + name + " is not a palindrome ");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePalindrome
{
    class Program
    {
        string str = null;
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            bool result = isPalindrom(str);
            if (result)
            {
                Console.WriteLine(str.ToUpper() + " is a palindrome");
            }
            else
            {
                Console.WriteLine(str.ToUpper() + " is not a palindrome");
            }
            Console.ReadLine();
        }

        private static bool isPalindrom(string str)
        {
            if (str.Length == 0 || str.Length == 1)
            {
                return true;
            }
            else
            {
                if (str.ElementAt(0) != str.ElementAt(str.Length - 1))
                {
                    return false;
                }
                else
                {
                    return isPalindrom(str.Substring(1, str.Length - 2));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            bool result= isInteger(str);
            if (result)
            {
                Console.WriteLine("It is a numerical value");
            }
            else
	{
                Console.WriteLine("It is not a numerical value");
	}
            Console.ReadLine();
        }

        private static bool isInteger(string str)
        {
            if (str.Length ==0)
            {
                return false;
            }
            else
            {
                if (str.Contains("1234"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

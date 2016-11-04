using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            Console.WriteLine("Enter the number to play game");
            n=int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {

                 if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("foo");
                }
                else if(i % 5 == 0)
                {

                    Console.WriteLine("Bar");
                }
                else
                Console.WriteLine(i);

            }
           
            Console.ReadLine();
        }
    }
}

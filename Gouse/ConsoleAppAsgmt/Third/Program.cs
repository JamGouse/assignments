using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
            Console.Write("Enter a value :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of a is : "+ a);
            Console.WriteLine("The value of ++a is : "+ ++a);
            Console.WriteLine("The value of a is : "+  a);
            Console.WriteLine("The value of a++ is : "+ a++);
            Console.WriteLine("The value of a is : "+ a);
            Console.WriteLine("The value of --a is : "+ --a);
            Console.WriteLine("The value of a is : " + a);
            Console.WriteLine("The value of --a is : " + a--);
            Console.WriteLine("The value of a is : " + a);

            Console.WriteLine("\nDo you want to continue? press(y/n)...");
            choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAsgmt
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
                Console.Write("Enter your age : "); ;
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("You are " + age + " years old \n");
                Console.WriteLine("Do you want to continue? press(y/n)...");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
            
        }
    }
}

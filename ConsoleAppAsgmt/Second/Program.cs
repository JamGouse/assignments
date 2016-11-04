using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
            Console.Write("Enter your Quiz Score: ");
            int qs = int.Parse(Console.ReadLine());
            Console.Write("Enter your Mid-Term Score: ");
            int ms = int.Parse(Console.ReadLine());
            Console.Write("Enter your Final Score: ");
            int fs = int.Parse(Console.ReadLine());

            int avg = (qs + ms + fs) / 3;
            Console.WriteLine("Your average score is : " + avg + "%");

            if (avg > 90)
                Console.WriteLine("Your have secured grade : A");
            else if(avg< 90 && avg>=70 )
                Console.WriteLine("Your have secured grade : B");
            else if (avg < 70 && avg >= 50)
                Console.WriteLine("Your have secured grade : C");
            else if (avg < 50)
                Console.WriteLine("Your have secured grade : F");
            Console.WriteLine("\nDo you want to continue? press(y/n)...");
            choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
            Console.Write("Please enter temprature degrees in Celsius °C: ");
            float cels = int.Parse(Console.ReadLine());
            Console.WriteLine("Temperature in Celsius is : "+cels+ "\x00B0C");
            float fah = (cels * 9 / 5) + 32;
            Console.WriteLine("Temprature from Celsius to Fahrenheit is: " + fah + "\x00B0F");
            Console.WriteLine("\nDo you want to continue? press(y/n)...");
            choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

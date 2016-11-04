using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeltoFar
{
    class CelToFar
    {
        static void Main(string[] args)
        {
            double cel, far;
            Console.WriteLine("Enter the to convert temperatures from Celsius \x00B0C to Fahrenheit \x00B0F");
            cel = int.Parse(Console.ReadLine());
            Console.WriteLine("The Entered Temprature in Celsius is:" + cel + "\x00B0");
            far = (1.8 * cel) + 32;
            Console.WriteLine("The convertd Temprature from Celsius \x00B0C to Fahrenheit \x00B0F is:" + far + "\x00B0");
            Console.ReadLine();
        }
    }
}

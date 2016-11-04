using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfPerson
{
    class AgeOfPerson
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the Person Age\n");
            i=int.Parse(Console.ReadLine());
            Console.WriteLine("You are\t"+ i +"\tYears old");
            Console.ReadLine();

        }
    }
}

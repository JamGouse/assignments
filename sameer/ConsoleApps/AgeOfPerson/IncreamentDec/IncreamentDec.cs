using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreamentDec
{
    class IncreamentDec
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the Value of a");
            i=int.Parse(Console.ReadLine());
            Console.WriteLine("the value of a is" + i);
            Console.WriteLine("........................");
        
            Console.WriteLine("the value of ++a is\t"+ ++i);
            Console.WriteLine("the value of a is\t"+ i);
            Console.WriteLine("the value of a++ is\t" + i++);
            Console.WriteLine("the value of a is\t" + i);
            Console.WriteLine("the value of --a is\t" + --i);
            Console.WriteLine("the value of a is\t" + i);
            Console.WriteLine("the value of a-- is\t" + i--);
            Console.WriteLine("the value of a is\t" + i);
            Console.ReadLine();

        }
    }
}

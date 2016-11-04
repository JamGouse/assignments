using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinals
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            Console.WriteLine("Entter the Number");
            k = int.Parse(Console.ReadLine());
            i = k % 10;
            
            if(i==1)
            {
                Console.WriteLine("That's the" + k + "st item");
            }
            else if (i== 2)
            {
                Console.WriteLine("That's the" + k + "nd item");
            }
            else if (i == 3)
            {
                Console.WriteLine("That's the" + k + "rd item");
            }
            //else if (i == 4)
            //{
            //    Console.WriteLine("That's the" + k + "th item");
            //}
            else
            {
                Console.WriteLine("That's the" + k + "th item");
            }
            Console.ReadLine();
        }
        
    }
}

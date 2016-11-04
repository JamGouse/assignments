using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestValue
{
    class GreatestValue
    {
        static void Main(string[] args)
        {
            int i, j, k, Avg;
            Console.WriteLine("Enter the Quize-Score , Mid-Term Score , Final-Score ");
            i = int.Parse(Console.ReadLine());
            j = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Avg = (i + j + k)/ 3;
            Console.WriteLine("The AVG is\t" + Avg +"%");
            //Avg = int.Parse(Console.ReadLine());
            if(Avg >= 90)
            {
                Console.WriteLine("You Got A Greade");
                Console.ReadLine();
            }
            else if(Avg >=70 &&  Avg < 90 )
            {
                Console.WriteLine("You got B grade");
                Console.ReadLine();
            }
            else if (Avg >= 50 && Avg < 90)
            {
                Console.WriteLine("You got c grade");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You got F grade");
                Console.ReadLine();
            }
            
          
        }
    }
}

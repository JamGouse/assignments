using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
           
            for( i = 6; i>=0 ; i--)
            {

                //Console.WriteLine("*");
               
                for( j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
              
            }

            Console.ReadLine();

        }
    }
}

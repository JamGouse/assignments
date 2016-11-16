using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] arr = new int[size][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[3];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (j != (arr[i].Length))
                    {
                        arr[i][j] = number;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

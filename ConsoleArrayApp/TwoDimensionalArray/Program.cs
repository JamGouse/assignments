using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] groups = new int[2, 2];
            //int[] firstGroup = new int[2];
            //int[] secondGroup = new int[2];
            int groupFirstMarks = 0;
            int groupSecondMarks = 0;
            Console.WriteLine("Enter 1st group marks :");
            for (int i = 0; i < 2; i++)
            {
                groupFirstMarks = int.Parse(Console.ReadLine());
                groups[0, i] = groupFirstMarks;
            }

            Console.WriteLine("Enter 2nd group marks :");
            for (int j = 0; j < 2; j++)
            {
                groupSecondMarks = int.Parse(Console.ReadLine());
                groups[1, j] = groupSecondMarks;
            }

            Console.WriteLine("Group marks are:");

            for (int i = 0; i < 2; i++)
            {
                int sum = 0;
                for (int j = 0; j < 2; j++)
                {
                    sum = sum + groups[i, j];
                }
                float avg = sum / 2;
                Console.WriteLine("Group average :" + avg + "\t");
            }
            Console.ReadLine();
        }
    }
}

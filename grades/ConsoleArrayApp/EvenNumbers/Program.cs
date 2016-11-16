using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter? :");
            int numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];
            Console.WriteLine("Enter " + numbers + " numbers");
            int item = 0;
            item = PrintArray(array, item);
            Console.WriteLine("Even numbers are :");
            EvenNumber(array);
            Console.ReadLine();
        }

        private static void EvenNumber(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("{0}", array[i]);
                }

            }
        }

        private static int PrintArray(int[] array, int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                item = int.Parse(Console.ReadLine());
                array.SetValue(item, i);
            }
            return item;
        }
    }
}

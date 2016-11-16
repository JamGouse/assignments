using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("How many numbers do you want to enter? :");
            int numbers = int.Parse(Console.ReadLine());
            int[] array = new int[numbers];
            Console.WriteLine("Enter " + numbers + " numbers");
            int item = 0;
            item = PrintArray(array, item);
            Console.WriteLine("Entered numbers are :");
            GetArray(array);
            Console.WriteLine("Entered numbers in reverse orders are: ");
            Reverse(array);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
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

        private static void GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }

        private static void Reverse(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

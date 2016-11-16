using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] data = { 10.5f, 9.7f, 8.0f };
            float max = Maximum(data);
            Console.WriteLine("Maximum real number is :" + max);
            Console.ReadLine();
        }

        private static float Maximum(float[] data)
        {
            float max = 0f;
            for (int i = 0; i < data.Length; i++)
            {
                if (max < data[i])
                {
                    max = data[i];
                }
            }
            return max;
        }

    }
}

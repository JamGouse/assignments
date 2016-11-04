using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPressed
{
    class KeyPressed
    {
        static void Main(string[] args)
        {
            char key;
            Console.WriteLine("Enter Your Input");
            key = (char)Console.Read();
            switch(key)
            {
                    
                case '0': Console.WriteLine("0 has been pressed");
                    Console.ReadLine();
                    break;

                case '1': Console.WriteLine("1 has been pressed");
                    Console.ReadLine();
                    break;
                case '2': Console.WriteLine("2 has been pressed"); 
                    Console.ReadLine();
                    break;

                case '3': Console.WriteLine("3 has been pressed"); 
                    Console.ReadLine();
                    break;
                case '4': Console.WriteLine("4 has been pressed");
                    Console.ReadLine();
                    break;
                case '5': Console.WriteLine("5 has been pressed");
                    Console.ReadLine();
                    break;
                case '6': Console.WriteLine("6 has been pressed");
                    Console.ReadLine();
                    break;
                case '7': Console.WriteLine("7 has been pressed");
                    Console.ReadLine();
                    break;
                case '8': Console.WriteLine("8 has been pressed");
                    Console.ReadLine();
                    break;
                case '9': Console.WriteLine("9 has been pressed");
                    Console.ReadLine();
                    break;
               
                default: Console.WriteLine("Not allowed");
                    Console.ReadLine();
                    break;
                   


            }
            Console.ReadLine();

        }
    }
}

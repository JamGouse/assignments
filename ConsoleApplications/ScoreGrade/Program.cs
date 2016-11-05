using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            do
            {
                Console.Write("Enter your Quiz Score: ");
                int QuizScore = int.Parse(Console.ReadLine());
                Console.Write("Enter your Mid-Term Score: ");
                int MidtermScore = int.Parse(Console.ReadLine());
                Console.Write("Enter your Final Score: ");
                int FinalScore = int.Parse(Console.ReadLine());

                int AverageScore = (QuizScore + MidtermScore + FinalScore) / 3;
                Console.WriteLine("Your average score is : " + AverageScore + "%");

                if (AverageScore > 90)
                    Console.WriteLine("Your have secured grade : A");
                else if (AverageScore < 90 && AverageScore >= 70)
                    Console.WriteLine("Your have secured grade : B");
                else if (AverageScore < 70 && AverageScore >= 50)
                    Console.WriteLine("Your have secured grade : C");
                else if (AverageScore < 50)
                    Console.WriteLine("Your have secured grade : F");
                Console.WriteLine("\nDo you want to continue? press(y/n)...");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }
    }
}

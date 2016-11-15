using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            string[][] books = new string[1000][];
            do
            {
                Console.WriteLine("Select following options");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1: Add a book");
                Console.WriteLine("2: Display books");
                Console.WriteLine("3: Search for the book");
                Console.WriteLine("4: Delete a book");
                Console.WriteLine("5: Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        books = AddBook(books);
                        break;

                    case 2: DisplayAllBooks(books);
                        break;

                    case 3: Console.WriteLine("Search for book ");
                        isBook(books);
                        break;
                    case 4: Console.WriteLine("Delete a book");
                        books = isDelete(books);
                        break;
                    case 5: return;

                    default: Console.WriteLine("Invalide option");
                        break;
                }

                Console.WriteLine("Do you want to continue? press(y/n)");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "yes");
        }

        private static string[][] isDelete(string[][] books)
        {
            Console.Write("Enter book number: ");
            string deleteByNumber = Console.ReadLine();
            for (int i = books.Length - 1; i >= 0; i--)
            {
                foreach (string[] item in books)
                {
                    if (item.Contains(deleteByNumber))
                    {

                        var result = books.ElementAt(i);
                        books = books.Where(x => x == result).ToArray();
                        Console.WriteLine("Book number " + deleteByNumber + " has deleted successfully!");
                        return books;
                    }
                }
            }
            Console.WriteLine("Book number " + deleteByNumber + " is not found!");
            return books;
        }

        private static void isBook(string[][] books)
        {
            Console.Write("Enter book title: ");
            string search = Console.ReadLine();
            Console.WriteLine("Book details are: ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Book Number\t| Book Title\t| Book Author");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (string[] item in books)
            {
                if (item.Contains(search))
                {
                    Console.WriteLine("{0}\t\t {1}\t\t {2}", item);
                }
            }
        }

        private static string[][] AddBook(string[][] books)
        {

            Console.Write("How Many books do you wish to add: ");
            int size = int.Parse(Console.ReadLine());
            string[][] arr = new string[size][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[3];
                Console.WriteLine("Enter book details: ");

                for (int j = 0; j < arr[i].Length; j++)
                {
                    string input = Console.ReadLine();
                    if (j != (arr[i].Length))
                    {
                        arr[i][j] = input;
                    }

                }
            }
            return arr;

        }

        private static string[][] DisplayAllBooks(string[][] books)
        {
            Console.WriteLine("Book details are: ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Book Number\t| Book Title\t| Book Author");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < books.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(books[i][j] + "\t\t");
                    //Console.Write("\t\t");
                }
                Console.WriteLine("");
            }
            return books;
        }
    }
}

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("Hello " + userAge);

            Console.ReadLine();
        }
    }
}

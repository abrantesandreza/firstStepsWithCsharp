using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(numberOne + numberTwo);

            Console.ReadLine();
        }
    }
}

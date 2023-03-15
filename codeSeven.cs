using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string color, pluralNoun, celebrityName;


            Console.WriteLine("Are you ready to play Mad Libs?");

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter the name of a celebrity: ");
            celebrityName = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrityName);


            Console.ReadLine();
        }
    }
}

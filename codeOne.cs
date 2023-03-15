using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Stacey";
            int characterAge;
            characterAge = 73;

            Console.WriteLine("There once was a woman named " + characterName);
            Console.WriteLine("She was " + characterAge);

            characterName = "Emily";
            Console.WriteLine("She really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}

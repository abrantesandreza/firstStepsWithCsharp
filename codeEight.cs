using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array of strings
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};

            //another way to create an array of strings
            string[] friends = new string[5];

            //populate the array
            friends[0] = "Rach";
            friends[1] = "Monica";
            friends[2] = "Phebees";
            friends[3] = "Ross";
            friends[4] = "Chan";
            friends[5] = "Joe";

            Console.WriteLine(luckyNumbers[4]);

            Console.ReadLine();
        }
    }
}

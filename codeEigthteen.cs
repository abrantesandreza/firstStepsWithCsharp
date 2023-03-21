using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6},
                {7, 8},
                {9, 10},
                {9, 8},
                {9, 65}
            };

            Console.WriteLine(numberGrid[2,0]); //5
            Console.WriteLine(numberGrid[0,1]); //2
            Console.WriteLine(numberGrid[3,1]); //8
            Console.WriteLine(numberGrid[5,0]); //9


        }

    }

}



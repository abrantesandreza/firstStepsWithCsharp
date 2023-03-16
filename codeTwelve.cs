using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetGreater(5, 8, 9)); //9
            Console.WriteLine(GetGreater(1695, 2, 1696)); //1696
            Console.WriteLine(GetGreater(-8,-10, 3)); //3

        }

        static int GetGreater(int numOne, int numTwo, int numThree)
        {
            int result;

            if (numOne > numTwo && numOne > numThree)
            {
                result = numOne;
            }
            else if (numTwo > numThree && numTwo > numOne)
            {
                result = numTwo;
            }
            else
            {
                result = numThree;
            }

            return result;
        }

        
    }

}


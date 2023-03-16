using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the method
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

        }
        //creating a method
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }

}


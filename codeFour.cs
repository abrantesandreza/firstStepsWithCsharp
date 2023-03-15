using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(5 + 3); //8
            Console.WriteLine(5 * 8); //40
            Console.WriteLine(5 % 2); //1
            Console.WriteLine(4 + 2 * 3); //10
            Console.WriteLine((4 + 2) * 3); //18
            Console.WriteLine(5.0 + 8.1); //13.1
            Console.WriteLine(5 / 2); //2
            Console.WriteLine(5 / 2.0); //2.5

            //Variables
            int num = 6;
            num++;
            Console.WriteLine(num);

            //Methods
            Console.WriteLine(Math.Abs(-40)); //40
            Console.WriteLine(Math.Pow(2, 8)); //256
            Console.WriteLine(Math.Pow(3.8, 2)); //14.44
            Console.WriteLine(Math.Sqrt(36)); //6
            Console.WriteLine(Math.Max(4, 91)); //91
            Console.WriteLine(Math.Min(4, 91)); //4
            Console.WriteLine(Math.Round(4.6)); //5
            Console.WriteLine(Math.Round(4.3)); //4



            //Console.ReadLine();
        }
    }
}

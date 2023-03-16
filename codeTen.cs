using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the method SayHi()
            SayHi("Mike", 23);
            SayHi("Andreza", 27);
            SayHi("Mon", 26);

        }
        //creating a method
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", you are " + age);
        }

    }

}


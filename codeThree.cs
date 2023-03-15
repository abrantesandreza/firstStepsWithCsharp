using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string phrase = "Giraffe Academy" + " is cool";
            Console.WriteLine(phrase.Length); //23
            Console.WriteLine(phrase.ToUpper()); //GIRAFFE ACADEMY IS COOL
            Console.WriteLine(phrase.ToLower()); //giraffe academy is cool
            Console.WriteLine(phrase.Contains("Academy")); //True
            Console.WriteLine(phrase[3]); //a
            Console.WriteLine(phrase.IndexOf("Academy")); //8
            Console.WriteLine(phrase.IndexOf('f')); //4
            Console.WriteLine(phrase.Substring(8)); //Academy
            Console.WriteLine(phrase.Substring(8, 3)); //Aca


            //Console.ReadLine();
        }
    }
}

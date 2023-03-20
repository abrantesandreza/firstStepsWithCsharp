using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPow(4, 3));

        }

        static int GetPow(int baseNum, int powNum)
        {

            int result = 1;
            for(int i =0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

    }

}



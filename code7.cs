using System;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que receba um número e calcule seu fatorial.

            Console.WriteLine("Digite um número e descubra o seu fatorial: ");
            int userResponse = int.Parse(Console.ReadLine());

            int result = 1;
            for(int i = 1; i <= userResponse; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }

    }

}



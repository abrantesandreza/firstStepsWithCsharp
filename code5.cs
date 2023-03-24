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

            //Escreva um programa que leia um número inteiro e exiba o fatorial desse número.
            
            Console.Write("Digite um número e descubra o seu fatorial: ");
            int userResponse = int.Parse(Console.ReadLine());

            Console.WriteLine(FatorialDe(userResponse));

        }

        static int FatorialDe(int number)
        {

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;

        }

    }

}



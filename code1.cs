using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escreva um programa que leia dois números inteiros e exiba o resultado da soma 
            //desses números.

            Console.Write("Entre um número inteiro: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Entre mais um número inteiro: ");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(numberOne + numberTwo);

        }

    }

}



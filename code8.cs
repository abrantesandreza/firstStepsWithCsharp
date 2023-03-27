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

            //Faça um programa que receba um número e verifique se ele é primo ou não.

            Console.Write("Digite um número e veja se ele é um número primo: ");
            int userResponse = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou o número: " + userResponse + ".");
            Console.WriteLine("Programa?!! O número " + userResponse + " é número primo? " + isPrime(userResponse));


        }

        static bool isPrime(int number)
        {
            if (number <= 1)
            {
                return false; //menor ou igual a 1, não é número primo
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; //se for divisível por qualquer número da lista, não é número primo
                }
            }

            return true; //se não for divisível por nenhum dos números (i), até chegar na sua raiz quadrada, então é número primo
        }

    }

}



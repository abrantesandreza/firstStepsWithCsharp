using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escreva um programa que leia um número inteiro e exiba se esse número 
            //é par ou ímpar.

            while (true)
            {

                Console.WriteLine();
                Console.Write("Entre com um número inteiro: ");
                int userNumber = int.Parse(Console.ReadLine());

                //checa se é par
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("O número " + userNumber + " é par!");
                }
                else if (userNumber % 2 == 1) //checa se é ímpar
                {
                    Console.WriteLine("O número " + userNumber + " é ímpar!");
                }

                //valida se o usuario quer continuar fazendo operações
                while (true)
                {
                    
                    Console.Write("Deseja fazer uma nova operação? S/N ");
                    char userAnswer = char.Parse(Console.ReadLine());

                    if (userAnswer == 'S' || userAnswer == 's')
                    {
                        break;
                    }
                    else if (userAnswer == 'N' || userAnswer == 'n')
                    {
                        Console.Write("Encerrando programa...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Você digitou algo errado!");
                        continue;
                    }

                }

            }

        }

    }

}


        

                
        




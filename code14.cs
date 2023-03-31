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

            /*Faça um programa que receba um número e retorne uma lista 
            contendo todos os números primos menores ou iguais a ele.*/

            Console.Write("Digite um número e retornaremos a lista com todos os números primos até o número de sua escolha: ");
            int userResponse = int.Parse(Console.ReadLine());

            Console.WriteLine("A lista de números inteiros é a seguinte: " + string.Join(", ", PrimeList(userResponse)));

        }
        
        static List<int> PrimeList(int userNumber)
        {

            List<int> finalPrimeList = new List<int>();

            for (int i = 2; i <= userNumber; i++)
            {

                //Chama a funcao IsPrime e verifica elemento por elemento
                if (IsPrime(i))
                {
                    //Caso IsPrime retorne True, add à finalPrimeList
                    finalPrimeList.Add(i);
                }

            }

            return finalPrimeList;
        }


        static bool IsPrime(int numberElement)
        {

            if (numberElement <= 1)
            {
                //Menor ou igual a 1, não é número primo
                return false; 
            }

            for (int i = 2; i <= Math.Sqrt(numberElement); i++)
            {

                if (numberElement % i == 0)
                {
                    //Se for divisível por qualquer número da interação, não é primo
                    return false; 
                }

            }

            //Se nao for divisível por nenhum numero das iteracoes, é primo
            return true;
        }

    }

}




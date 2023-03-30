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

            /*Faça um programa que receba uma lista de números e retorne uma lista contendo apenas 
            os números pares.*/

            Console.Write("Digite uma lista de números: ");
            string userResponse = Console.ReadLine();

            //Divide a entrada em substrings baseado nos parametros passados
            string[] stringList = userResponse.Split(',',' ');

            //Converte as substrings em uma lista de inteiros
            List<int> userResponseList = stringList.Select(int.Parse).ToList();


            Console.WriteLine("Da sua lista, os números pares são os seguintes: " + string.Join(", ", WhichOneIsPair(userResponseList)));

        }

        static List<int> WhichOneIsPair(List<int> numbersList)
        {

            List<int> isPair = new List<int>();

            for (int i = 0; i < numbersList.Count; i++) 
            {
                //Condicao para checar se o elemento da iteracao é par
                if (numbersList[i] % 2 == 0)
                {
                    //Se a condicao for satisfeita, add em isPair
                    isPair.Add(numbersList[i]);
                }
            }

            return isPair;
        }

    }

}




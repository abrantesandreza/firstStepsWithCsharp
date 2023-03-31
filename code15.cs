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

            /*Faça um programa que receba uma lista de nomes e retorne uma lista contendo 
            apenas os nomes que começam com a letra "A".*/

            Console.WriteLine("Digite algumas palavras e te mostraremos quais começam com A: ");
            string userResponse = Console.ReadLine();

            //Converte a string em substrings divididas a partir do parametro 
            string[] divideUserResponse = userResponse.Split(',',' ');
            
            //Converte as substrings em uma lista de substrings
            List<string> userResponseSubstrings = divideUserResponse.ToList();

            Console.WriteLine("As palavras que começam com A segundo a sua lista, são: " + string.Join(", ", StartsWithA(userResponseSubstrings)));

        }

        static List<string> StartsWithA(List<string> stringsList)
        {

            List<string> wordsStartsWithA = new List<string>();

            for (int i = 0; i < stringsList.Count; i++)
            {

                //Busca a primeira letra da palavra da iteração e add em wordsStartsWithA
                if (stringsList[i][0] == 'A' || stringsList[i][0] == 'a')
                {
                    wordsStartsWithA.Add(stringsList[i]);
                }

            }

            return wordsStartsWithA;
        }

    }

}




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

            /*Faça um programa que receba duas strings e verifique se elas são anagramas (ou seja, 
            se possuem as mesmas letras, mas em ordem diferente).*/

            Console.WriteLine("A seguir, escreva duas palavras e verificarei se são anagramas!");
            Console.Write("Digite a primeira palavra: ");
            string firstWord = Console.ReadLine();

            Console.Write("Digite a segunda palavra: ");
            string secondWord = Console.ReadLine();


            bool areAnagrams = AreAnagrams(firstWord, secondWord);

            Console.WriteLine($"As palavras {firstWord} e {secondWord} {(areAnagrams ? "são" : "não são")} anagramas");

        }

        static bool AreAnagrams(string firstWord, string secondWord)
        {

            if (firstWord.Length != secondWord.Length) 
            {
                return false;
            }

            List<char> firstChars = firstWord.ToList();
            List<char> secondChars = secondWord.ToList();

            firstChars.Sort();
            secondChars.Sort();

            return AreStringEqual(firstChars, secondChars);

        }

        static bool AreStringEqual(List<char> orderlyFirstList, List<char> orderlySecondList)
        {

            if (orderlyFirstList.Count != orderlySecondList.Count)
            {
                return false;
            }

            for (int i = 0; i < orderlyFirstList.Count; i++)
            {
                if (orderlyFirstList[i] != orderlySecondList[i])
                {
                    return false;
                }
            }

            return true;
        }

    }

}


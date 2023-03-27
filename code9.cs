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

            //Faça um programa que receba uma frase e verifique se ela é um palíndromo
            //(ou seja, se pode ser lida da mesma forma de trás para frente).

            Console.WriteLine("Escreva uma frase e verificaremos se é um palíndromo: ");
            string userResponse = Console.ReadLine();
            char[] divideUserResponse = { ' ','.',',',';',':','!','?' };

            List<string> newUserResponse = userResponse.Split(divideUserResponse, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(IsPalindrome(newUserResponse));
        }

        static bool IsPalindrome(List<string> phrase)
        {

            List<char> phraseChars = new List<char>();

            foreach (string word in phrase) 
            {
                phraseChars.AddRange(word.ToCharArray());
            }

            List<char> backwards = new List<char>();

            for (int i = phraseChars.Count - 1; i >= 0; i--)
            {
                backwards.Add(phraseChars[i]);
            }

            return IsListEqual(phraseChars, backwards);

        }

        static bool IsListEqual(List<char> firstList, List<char> secondList)
        {
            if (firstList.Count != secondList.Count)
            {
                return false;
            } 

            for (int i = 0; i < firstList.Count; i++)
            {
                if (firstList[i] != secondList[i]) 
                {
                    return false;
                }
            }

            return true;
        }

    }

}



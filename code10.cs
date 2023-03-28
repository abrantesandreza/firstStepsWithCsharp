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

            /*Faça um programa que receba uma lista de números e ordene-os em ordem crescente.*/

            Console.Write("Escreva números aleatórios, separados por vírgula, e retornaremos em ordem crescente para você: ");
            string messyUserResponse = Console.ReadLine();

            //Divide a string em substrings, com base na vírgula
            string[] divideMessyUserResponse = messyUserResponse.Split(',');

            //Lista vazia para receber o input na forma de inteiros
            List<int> cleanUserResponse = new List<int>();

            //Transforma cada substring em numero inteiro e popula cleanUserResponse
            foreach (string number in divideMessyUserResponse)
            {
                int cleanerNumbers;
                if (int.TryParse(number, out cleanerNumbers))
                {
                    cleanUserResponse.Add(cleanerNumbers);
                }
            }

            Console.Write(string.Join(", ", SortNumbers(cleanUserResponse)));

        }

        static List<int> SortNumbers(List<int> messyNumbers)
        {

            if (messyNumbers.Count <= 1)
            {
                return messyNumbers;
            }

            List<int> greatest = new List<int>();
            List<int> lowest = new List<int>();

            int target = messyNumbers[0];

            for (int i = 1; i < messyNumbers.Count; i++) 
            {
                if (target < messyNumbers[i])
                {
                    greatest.Add(messyNumbers[i]);
                } else
                {
                    lowest.Add(messyNumbers[i]);
                }
            }


            greatest = SortNumbers(greatest);
            lowest = SortNumbers(lowest);

            lowest.Add(target);
            lowest.AddRange(greatest);

            return lowest;

        }

    }

}




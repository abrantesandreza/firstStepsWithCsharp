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

            //Variavel para receber o metodo AreAnagrams e ser utilizado no console de maneira mais otimizada
            bool areAnagrams = AreAnagrams(firstWord, secondWord);

            Console.WriteLine($"As palavras {firstWord} e {secondWord} {(areAnagrams ? "são" : "não são")} anagramas");

        }

        static bool AreAnagrams(string firstWord, string secondWord)
        {

            //Verifica se os tamanhos sao diferentes, se sim, já retorna falso
            if (firstWord.Length != secondWord.Length) 
            {
                return false;
            }

            //Converte as strings em listas de caracteres
            List<char> firstChars = firstWord.ToList();
            List<char> secondChars = secondWord.ToList();

            //Ordena as listas de caracteres
            firstChars.Sort();
            secondChars.Sort();

            //Chama o metodo AreStringEqual e as duas listas já ordenadas como parametro
            return AreStringEqual(firstChars, secondChars);

        }

        static bool AreStringEqual(List<char> orderlyFirstList, List<char> orderlySecondList)
        {
            
            //Verifica se os tamanhos sao diferentes, se sim, já retorna falso
            if (orderlyFirstList.Count != orderlySecondList.Count)
            {
                return false;
            }

            //Itera sobre cada caracter e compara as duas listas
            for (int i = 0; i < orderlyFirstList.Count; i++)
            {
                if (orderlyFirstList[i] != orderlySecondList[i])
                {
                    return false;
                }
            }

            //Se nao entrar no if, nenhum caracter e diferente, retorna true
            return true;
        }

    }

}


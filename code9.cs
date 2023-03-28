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

            /*Faça um programa que receba uma frase e verifique se ela é um palíndromo
            (ou seja, se pode ser lida da mesma forma de trás para frente).*/

            Console.WriteLine("Escreva uma frase e verificaremos se é um palíndromo: ");
            string userResponse = Console.ReadLine();

            //Cria uma matriz de caracteres para dividir a resposta do usuario
            char[] divideUserResponse = { ' ','.',',',';',':','!','?' };

            //Cria uma nova lista de strings dividida em pedaços menores a partir de userResponse
            List<string> newUserResponse = userResponse.Split(divideUserResponse, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Chama a função IsPalindrome passando a nova lista, dividida, como parametro
            Console.WriteLine(IsPalindrome(newUserResponse)); 

        }

        static bool IsPalindrome(List<string> phrase)
        {

            //Cria uma lista vazia para receber os caracteres da frase 'phrase'
            List<char> phraseChars = new List<char>();

            //Itera sobre a frase recebida em pedaços menores, converte em caractere e popula a lista, antes vazia, phraseChars
            foreach (string word in phrase) 
            {
                phraseChars.AddRange(word.ToCharArray());
            }

            //Cria uma lista vazia para receber os caracteres invertidos da lista populada 'phraseChars'
            List<char> backwards = new List<char>();

            //Itera sobre phraseChars, reverte todos os caracteres e popula na lista, antes vazia, backwards
            for (int i = phraseChars.Count - 1; i >= 0; i--)
            {
                backwards.Add(phraseChars[i]);
            }

            //Chama a função IsListEqual e verifica as duas listas 
            return IsListEqual(phraseChars, backwards); 

        }

        //Função genérica para iterar sobre cada caracter e comparar duas listas de caracteres
        static bool IsListEqual(List<char> firstList, List<char> secondList)
        {
            //Caso as listas tenham tamanhos diferentes, já retorna false
            if (firstList.Count != secondList.Count)
            {
                return false;
            } 

            //Itera por cada caracter e compara as duas listas, se nenhum caracter for diferente, sai do for e retorna true
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




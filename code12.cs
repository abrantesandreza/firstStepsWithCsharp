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

            /*Faça um programa que receba uma lista de números e retorne a média, o maior 
            e o menor valor.*/

            Console.WriteLine("Abaixo, digite vários números e retornarei a média, o menor número e o maior:");
            Console.Write("Digite os números: ");
            string userResponse = Console.ReadLine();

            //Divide a entrada em substrings atraves dos parametros passados
            string[] stringList = userResponse.Split(',', ' ', '/', ';');

            //Converte a entrada em uma lista de inteiros
            List<int> userResponseList = stringList.Select(int.Parse).ToList();

            //Variavel para receber o método LowestAndGreatest
            Tuple<int, int> lowestAndGreatest = LowestAndGreatest(userResponseList);

                        
            Console.WriteLine("A média dos números é: " + Media(userResponseList) + " e o menor e maior número, respectivamente, são: " + lowestAndGreatest.Item1 + " e " + lowestAndGreatest.Item2);

        }

        static double Media(List<int> listaNumeros) 
        {

            int somaTemporaria = 0;

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                somaTemporaria =+ listaNumeros[i];  
            }

            double mediaTotal = (double)somaTemporaria / listaNumeros.Count;

            return mediaTotal;
        }

        static Tuple<int, int> LowestAndGreatest(List<int> listaNumeros) 
        {

            List<int> listaNumerosOrdenados = new List<int>();

            //listaNumerosOrdenados recebe listaNumeros
            listaNumerosOrdenados.AddRange(listaNumeros);

            //A lista é ordenada
            listaNumerosOrdenados.Sort();

            //Acessa o menor numero da lista ordenada e guarda em lowest
            int lowest = listaNumerosOrdenados[0];
            //Acessa o maior numero da lista ordenada e guarda em greatest
            int greatest = listaNumerosOrdenados[listaNumerosOrdenados.Count - 1];

            return new Tuple<int, int>(lowest, greatest);
                       
        }

    }

}




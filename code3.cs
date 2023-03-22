using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escreva um programa que leia um número inteiro e exiba a sua tabuada(de 1 a 10).

            while (true)
            {
                int numTabuada;

                //validacao da entrada do usuario
                Console.Write("Você quer a tabuada de qual número? ");
                while(!int.TryParse(Console.ReadLine(), out numTabuada))
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.Write("Insira um novo valor: ");
                }

                //execução da tabuada
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numTabuada + " * " + i + " = " + (numTabuada * i));
                }
                Console.WriteLine("-------------");

                while (true)
                {

                    //validacao para continuar ou encerrar o programa
                    Console.Write("Você quer a tabuada de outro número? S/N ");
                    string userResponse = (Console.ReadLine());

                    if (userResponse == "S" || userResponse == "s")
                    {
                        Console.WriteLine("------------------------------------");
                        break;                       
                    } else if (userResponse == "N" || userResponse == "n")
                    {
                        Console.WriteLine("Você escolheu encerrar o programa...");
                        return;
                    } else
                    {
                        Console.WriteLine("Não entendi o que digitou! Vamos tentar novamente...");
                        continue;
                    }

                }
                
            }

        }

    }

}


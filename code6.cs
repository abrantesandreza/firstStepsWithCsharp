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

            //Faça um programa que receba dois números e calcule a soma, subtração, multiplicação e divisão.
            while (true)
            {

                char operation;
                
                Console.Write("Escolha a operação que deseja executar: '+' '-' '*' '/' ");
                //Validando a entrada da operação
                while(!char.TryParse(Console.ReadLine(), out operation) || !"+-*/".Contains(operation))
                {
                    Console.WriteLine("Desculpe, valor inválido! Digite umas das seguintes operações: '+', '-', '*', '/': ");
                }

                int numberOne, numberTwo;

                Console.Write("Escolha um número: ");
                //Validando as entradas dos números
                while (!int.TryParse(Console.ReadLine(), out numberOne))
                {
                    Console.WriteLine("Desculpe, valor inválido! Digite um número inteiro: ");
                }

                Console.Write("Escolha mais um número: ");
                while (!int.TryParse(Console.ReadLine(), out numberTwo))
                {
                    Console.WriteLine("Desculpe, valor inválido! Digite mais um número inteiro: ");
                }

                //Chamando as funções e fazendo seus cálculos específicos
                if (operation == '+')
                {
                    Console.WriteLine("Sua operação escolhida foi: " + operation + " e o resultado foi: " + AditionFunction(numberOne, numberTwo));
                }
                else if (operation == '-')
                {
                    SubtractionFunction(numberOne, numberTwo);
                    Console.WriteLine("Sua operação escolhida foi: " + operation + " e o resultado foi: " + SubtractionFunction(numberOne, numberTwo));
                }
                else if (operation == '*')
                {
                    MultiplicationFunction(numberOne, numberTwo);
                    Console.WriteLine("Sua operação escolhida foi: " + operation + " e o resultado foi: " + MultiplicationFunction(numberOne, numberTwo));
                }
                else if (operation == '/')
                {
                    DivisionFunction(numberOne, numberTwo);
                    Console.WriteLine("Sua operação escolhida foi: " + operation + " e o resultado foi: " + DivisionFunction(numberOne, numberTwo));
                }

                //Verificando se o usuario deseja fazer outra operação ou sair do programa
                while (true)
                {
                    Console.Write("Você deseja fazer outra operação? S/N ");
                    char userResponse = char.Parse(Console.ReadLine());

                    if (userResponse == 'S' || userResponse == 's')
                    {
                        break;
                    } else if (userResponse == 'N' || userResponse == 'n')
                    {
                        Console.WriteLine("Você escolheu encerrar o programa...");
                        return;
                    } else {
                        Console.WriteLine("Não entendi o que falou, vamos tentar novamente, então!");
                        continue;
                    }

                }

            }

        }

        //Funções separadas para cada operação
        static int AditionFunction(int firstNumber, int secondNumber)
        {

            int aditionResult = firstNumber + secondNumber;
            return aditionResult;

        }

        static int SubtractionFunction(int firstNumber, int secondNumber)
        {

            int subtractionResult = firstNumber - secondNumber;
            return subtractionResult;

        }

        static int MultiplicationFunction(int firstNumber, int secondNumber)
        {

            int multiplicationResult = firstNumber * secondNumber;
            return multiplicationResult;

        }

        static int DivisionFunction(int firstNumber, int secondNumber)
        {

            int divisionResult = firstNumber / secondNumber;
            return divisionResult;

        }

    }

}



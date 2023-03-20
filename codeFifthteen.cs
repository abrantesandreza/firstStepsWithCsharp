using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //validacao inicial para começar o programa
            Console.Write("Você gostaria de fazer uma comparação entre três números? S/N ");
            char iniciarPrograma = char.Parse(Console.ReadLine());

            if (iniciarPrograma == 'S' || iniciarPrograma == 's')
            {
                while (true)
                {

                    int userNumberOne, userNumberTwo, userNumberThree;

                    Console.Write("Digite um número: ");
                    //validacao do primeiro input
                    while (!int.TryParse(Console.ReadLine(), out userNumberOne))
                    {
                        Console.WriteLine("Valor inválido! Digite novamente o primeiro número: ");
                    }

                    Console.Write("Digite o segundo número: ");
                    //validacao do segundo input
                    while (!int.TryParse(Console.ReadLine(), out userNumberTwo))
                    {
                        Console.WriteLine("Valor inválido! Digite novamente o segundo número: ");
                    }

                    Console.Write("Digite o terceiro número: ");
                    //validacao do terceiro input
                    while (!int.TryParse(Console.ReadLine(), out userNumberThree))
                    {
                        Console.WriteLine("Valor inválido! Digite novamente o terceiro número: ");
                    }

                    //chama a funcao GetGreater, compara os numeros e retorna maior 
                    int result = GetGreater(userNumberOne, userNumberTwo, userNumberThree);
                    Console.WriteLine("Este é o maior número dentre os que você escolheu: " + result);

                    Console.WriteLine("---------------------------------------------------------");

                    //checa se o usuario deseja continuar ou sair do programa
                    Console.Write("Deseja realizar outra comparação? S/N ");
                    char breakOperation = char.Parse(Console.ReadLine());

                    if (breakOperation == 'S' || breakOperation == 's')
                    {
                        continue;
                    }
                    else if (breakOperation == 'N' || breakOperation == 'n')
                    {
                        Console.WriteLine("Você escolheu encerrar o programa...");
                        break;
                    }

                }

            } 
            else
            {
                Console.WriteLine("Você escolheu encerrar o programa...");
            }

        }

        static int GetGreater(int numberOne, int numberTwo, int numberThree)
        {

            int result;
            //compara e retorna o maior numero
            if(numberOne > numberTwo && numberOne > numberThree)
            {
                result = numberOne;
            } else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                result = numberTwo;
            } else
            {
                result = numberThree;
            }

            return result;

        }

    }

}

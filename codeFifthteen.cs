using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Digite um número: ");
                int userNumberOne = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int userNumberTwo = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                int userNumberThree = int.Parse(Console.ReadLine());


                int result = GetGreater(userNumberOne, userNumberTwo, userNumberThree);
                Console.WriteLine("Este é o maior número dentre os que você escolheu: " + result);


                Console.Write("Deseja realizar outra comparação? S/N " );
                char breakOperation = char.Parse(Console.ReadLine());

                if (breakOperation == 'S' || breakOperation == 's')
                {
                    continue;
                } else if (breakOperation == 'N' || breakOperation == 'n')
                {
                    break;
                }


            }
        }

        static int GetGreater(int numberOne, int numberTwo, int numberThree)
        {

            int result;

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


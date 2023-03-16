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

                //user escolhe a operacao
                Console.Write("Escolha a operação que deseja fazer: '+' ou '-' ou '*' ou '/': ");
                string operation = Console.ReadLine();


                //condicao de operacao
                if (operation == "+")
                {

                    Console.Write("Escolha um número: ");
                    double numberOne = double.Parse(Console.ReadLine());

                    Console.Write("Escolha mais um número: ");
                    double numberTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Você escolheu a operação: " + operation + " e seu resultado foi: " + (numberOne + numberTwo));
                    Console.WriteLine("----------------------------------------------------");

                }
                else if (operation == "-")
                {

                    Console.Write("Escolha um número: ");
                    double numberOne = double.Parse(Console.ReadLine());

                    Console.Write("Escolha mais um número: ");
                    double numberTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Você escolheu a operação: " + operation + " e seu resultado foi: " + (numberOne - numberTwo));
                    Console.WriteLine("----------------------------------------------------");
                }
                else if (operation == "*")
                {

                    Console.Write("Escolha um número: ");
                    double numberOne = double.Parse(Console.ReadLine());

                    Console.Write("Escolha mais um número: ");
                    double numberTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Você escolheu a operação: " + operation + " e seu resultado foi: " + (numberOne * numberTwo));
                    Console.WriteLine("----------------------------------------------------");

                }
                else if (operation == "/")
                {

                    Console.Write("Escolha um número: ");
                    double numberOne = double.Parse(Console.ReadLine());

                    Console.Write("Escolha mais um número: ");
                    double numberTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Você escolheu a operação: " + operation + " e seu resultado foi: " + (numberOne / numberTwo));
                    Console.WriteLine("----------------------------------------------------");

                }

                Console.Write("Deseja fazer outra operação? S/N ");
                char response = char.Parse(Console.ReadLine());

                if(response == 'S' || response == 's')
                {
                    continue;
                } 
                else if (response == 'N' || response == 'n')
                {
                    break;
                }
             
            }
        
        }
      
    }

}


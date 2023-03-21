using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1) Implemente um método que crie um novo array baseado nos valores passados.
            Entradas do método (3,a), Resultado do método: ['a', 'a', 'a'] */

            Console.Write("Entre com a quantidade: ");
            int lengthNewArray = int.Parse(Console.ReadLine());
            Console.Write("Entre com uma letra: ");
            string repeatedChar = Console.ReadLine();
            
            //declarando a string de arrays com a quantidade passada pelo usuario
            string[] myArray = new string[lengthNewArray]; 

            for(int i = 0; i < lengthNewArray; i++)
            {
                myArray[i] = repeatedChar; //populando o array criado com a letra que o usuario passou
            }

            Console.WriteLine("Resultado: [" + string.Join(", ", myArray) + "]");

        }

    }

}



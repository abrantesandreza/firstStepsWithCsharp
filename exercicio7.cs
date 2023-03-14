using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //recebe uma frase e separá-las em variaveis especificas para cada palavra

            Console.WriteLine("Escreva 3 palavras:");

            string palavrasNovas = Console.ReadLine();

            string[] vet = palavrasNovas.Split(' ');

            string palavra1 = vet[0];
            string palavra2 = vet[1];
            string palavra3 = vet[2];

            Console.WriteLine(palavra1 + ' ' + palavra2 + ' ' + palavra3);
            
        }
    }
}
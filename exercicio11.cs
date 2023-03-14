using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ler um nome (unica palavrea), sexo (caractere F ou M), idade (inteiro)
            e altura (double) na mesma linha, armazenando-os em quatro variaveis com 
            seus devidos tipos*/

            Console.WriteLine("Qual seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o seu sexo? F/M");
            char sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura? ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Você, " + nome + " do sexo " + sexo + " tem " + idade + " anos e tem " + altura.ToString("F2",  CultureInfo.InvariantCulture) + " de altura!");


            // Outra forma

            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome + ' ' + sexo + ' ' + idade + ' ' + altura.ToString("F2",  CultureInfo.InvariantCulture));


        }
    }
}

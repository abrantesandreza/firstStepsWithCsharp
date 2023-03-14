using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qntQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine("Entre seu sobrenome, idade e altura (na mesma linha): ");
            string[] infoPessoa = Console.ReadLine().Split(' ');

            string sobrenome = infoPessoa[0];
            int idade = int.Parse(infoPessoa[1]);
            double altura = double.Parse(infoPessoa[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(qntQuartos);
            Console.WriteLine(preco.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));


        }
    }
}

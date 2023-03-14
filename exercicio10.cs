using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //ler um numero double

            //CultureInfo.InvariantCulture para conseguir ler o ponto (.) como uma virgula
            //no numero flutuante
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //.ToString("F2", CultureInfo.InvariantCulture) para imprimir para o usuario com um
            //ponto também e não uma vígula (é opcional)
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //pergunte ao usuario o nome completo, a idade e a
            //cidade em que mora, e depois mostre tudo na tela

            Console.WriteLine("Qual seu nome completo?");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            string idade = Console.ReadLine();

            Console.WriteLine("Onde você mora?");
            string lugarQueMora = Console.ReadLine();


            Console.WriteLine("Você, " + nomeCompleto + ", tem " + idade + " anos" + " e mora em " + lugarQueMora + "!");
            
        }
    }
}

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //21 questions

            string secretWord = "white car";
            string userGuess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;


            
            while (userGuess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {

                    Console.Write("Adivinhe a palavra: ");
                    userGuess = Console.ReadLine();
                    guessCount++;

                } else
                {
                    outOfGuesses = true;
                }

            }

            if (outOfGuesses)
            {
                Console.Write("Você perdeu!");
            } else
            {
                Console.WriteLine("Você acertou!");
            }

            

        }

    }

}


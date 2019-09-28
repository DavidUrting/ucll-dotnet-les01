using System;

namespace Oefening03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de UCLL Quiz!");

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine();

                Quiz quiz = new Quiz();
                quiz.Play();

                // Nogmaals spelen?
                bool correcteInput = false;
                while (!correcteInput)
                {
                    Console.WriteLine();
                    Console.Write("Nog eens spelen (J/Y of N)? ");
                    ConsoleKeyInfo cki = Console.ReadKey();

                    if (cki.Key == ConsoleKey.J || cki.Key == ConsoleKey.Y)
                    {
                        correcteInput = true;
                        playAgain = true;
                    }
                    else if (cki.Key == ConsoleKey.N)
                    {
                        correcteInput = true;
                        playAgain = false;
                    }
                }
            }
        }
    }
}

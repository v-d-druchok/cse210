using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string cont = "yes";
        while (cont == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guessNumber = 0;
            int guessCount = 0;

            while (guessNumber != number)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                
                if (number > guessNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (number < guessNumber)
                {
                    Console.WriteLine("Lower");
                }

                guessCount += 1;

            }

            Console.WriteLine($"It took you {guessCount} guesses to get the magic number!");

            Console.Write("Do you want to play again? ");
            cont = Console.ReadLine();
        }
    }
}
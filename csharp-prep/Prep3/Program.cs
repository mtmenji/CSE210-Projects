using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "y";
        while (play == "y")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guess = -1;
            int loopCounter = 0;

            do
            {
                Console.WriteLine("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

                loopCounter ++;
            } while (guess != magicNumber);

            Console.WriteLine($"It took you {loopCounter} tries to find the magic number.");

            Console.WriteLine("Do you wish to play again? (y/n)");
            play = Console.ReadLine();
        }
    }
}
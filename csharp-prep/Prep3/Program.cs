using System;

class Program
{
    static void Main(string[] args)
    {

        int tries = 0;
        string play = "Y";
        Console.WriteLine("");

        while (play == "Y" || play == "y" || play == "Yes" || play == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            for (int guess = 0; guess != number;)
            {

                Console.Write("What is your guess? ");
                string stGuess = Console.ReadLine();
                guess = int.Parse(stGuess);

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                }

                tries += 1;
            }
            Console.WriteLine($"You found the magic number in {tries} tries.");

            Console.Write("Do you want to play again? Y/N: ");
            play = Console.ReadLine();
        }

    }
}
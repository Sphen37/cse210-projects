using System;

class Program
{
    static void Main(string[] args)
    {
        string continuePlaying = "no";
        do
        {
            Random randomNumber = new Random();
            double magicNumber = randomNumber.Next(1,100);
            Console.Write("What is your guess? ");
            double yourGuess = double.Parse(Console.ReadLine());
            do
            {
                if (yourGuess < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else if (yourGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                yourGuess = double.Parse(Console.ReadLine());
                if (yourGuess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write("Would you like to continue playing? ");
                    continuePlaying = Console.ReadLine();
                    continuePlaying = continuePlaying.ToLower();
                }
            } while (yourGuess != magicNumber);
        } while (continuePlaying == "yes");
    }
}
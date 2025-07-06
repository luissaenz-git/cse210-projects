using System;

class Program
{
    static void Main(string[] args)
    {
        Random randonGenerator = new Random(); // CreateS a random number generator

        string playAgain = "yes";


        while (playAgain == "yes")
        {
            int number = randonGenerator.Next(1, 100);
            int counter = 0;
            int guessNumber = 0;

            Console.WriteLine($"What is the magic number? {number}");

            int magicNumber = number;

            do //If the user guesses the number, the loop will stop, even in the first try
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();   //not needed to declare again the data type later
                guessNumber = int.Parse(userInput);
                counter++; //Increment the counter plus 1 for each guess
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it after {counter} tries!");
                }

            } while (guessNumber != magicNumber) ;

                Console.Write("Do you want to play again? (yes/no) ");
                playAgain = Console.ReadLine().ToLower(); // Convert input to lowercase for consistency

            }
            Console.WriteLine("Thanks for playing!");
    }
}



using System;

class Program
{
    static void Main(string[] args)
    {
        

      {
         // Generate a random magic number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        
        int guess = -1; // Initialize guess with a value that won't match the magic number
        
        // Loop until the user guesses the correct number
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Check if the guess is higher, lower, or equal to the magic number
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        

      }
        

        
    }
}
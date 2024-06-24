using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;



class Program
{
    
    static void Main(string[] args)
    {
        string proceed;
        do
        {
            PlayGame();
            Console.Write("Would you like to play again? (YES/NO): ");
            proceed = Console.ReadLine().ToUpper();
        } while (proceed == "YES");

        Console.WriteLine("Thank you for playing! See you next time.");

    }
    static void PlayGame()
    {
        int guess = -1;
        Random random = new Random();
        int correctNumber = random.Next(1, 11);
        int guessCount = 0;
        while (guess != correctNumber)
        {
            guessCount += 1;
            Console.Write("Enter a number between 1 and 10: ");
            guess = int.Parse(Console.ReadLine());
            if (guess < correctNumber)
            {
                Console.WriteLine("Lower! Try again");
            } 
            else if (guess > correctNumber)
            {
                Console.WriteLine("Higher! Try agai");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it");
                Console.WriteLine($"It took you {guessCount} guesses");
            }     
        }
        
    }
}
   
        
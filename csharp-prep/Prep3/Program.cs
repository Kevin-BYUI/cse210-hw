using System;

class Program
{
    static void Main(string[] args)
    {

      {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magic = int.Parse(magicNumber);
        
        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int guess = int.Parse(guessNumber);

        if (magic < guess)
        {
            Console.WriteLine("Lower");
        }
        if (magic > guess)
        {
            Console.WriteLine("Higher");
        }
        if (magic == guess)
        {
            Console.WriteLine("You guesses it!");
        }


      }
        

        
    }
}
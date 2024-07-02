using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding");

        Console.WriteLine("How many words would you like to hide at a time?");
        int numberToHide;
        while (!int.TryParse(Console.ReadLine(), out numberToHide) || numberToHide < 1)
        {
            Console.WriteLine("Please enter a valid number greater than 0.");
        }

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words, type 'hint' for a hint, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            else if (input.ToLower() == "hint")
                scripture.RevealRandomHiddenWord();
            else
                scripture.HideRandomWords(numberToHide); // Hide the specified number of random words
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Well done!");
        
    }
}
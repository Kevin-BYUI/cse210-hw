using System;

class Program
{
    static void Main(string[] args)
    {
        // {
            // Exceeding requirement;
            // This is gratitudeActivity
            // This activity will prompt the user to reflect on things they are grateful for. 
            // they could be holistic achievements
            // Or even simple ones.
        Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        GratitudeActivity gratitudeActivity = new GratitudeActivity();

        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Start gratitude activity.");
            Console.WriteLine("5. Quit.");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                breathingActivity.DisplayStartingMessage();
                breathingActivity.DisplayDescription();
                breathingActivity.DisplayDuration();
                Console.Clear();
                breathingActivity.RunBreathingActivity();
                Console.Clear();
            }
            else if (choice == 2)
            {    
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.DisplayDescription();
                reflectingActivity.DisplayDuration();
                Console.Clear();
                reflectingActivity.RunReflectingActivity();
                reflectingActivity.DisplayPrompt();
                reflectingActivity.DisplayQuestion();
                Console.Clear();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.DisplayDescription();
                listingActivity.DisplayDuration();
                Console.Clear();
                listingActivity.RunListingActivity();
                Console.Clear();
            }
            else if (choice == 4)
            {
                gratitudeActivity.DisplayStartingMessage();
                gratitudeActivity.DisplayDescription();
                gratitudeActivity.DisplayDuration();
                gratitudeActivity.DisplayPrompts();
                Console.Clear();    
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }
        }      
    }
}

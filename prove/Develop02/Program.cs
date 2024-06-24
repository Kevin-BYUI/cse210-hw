using System;

class Program
{
    private static Journal journal = new Journal();
    private static Random random = new Random();
    static void Main(string[] args)
    {
         bool exit = false;
        while (!exit)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string randomPrompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd"); // Example date format

        JournalEntry entry = new JournalEntry(randomPrompt, response, date);
        journal.AddEntry(entry);
    }

    static void DisplayJournal()
    {
        journal.DisplayEntries();
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved to file successfully.");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded from file successfully.");
    }
}
        
    

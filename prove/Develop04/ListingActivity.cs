using System.Runtime.InteropServices.Marshalling;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will take you through the good things that have happened in your life by having you list them as many as you can in a certain criteria.";
        _prompts = new List<string> {
            "---What good things have you done this Month? ",
            "---What lessons can you grasp from what was taught in Church last Sunday? ",
            "---If you were to write the best thing that has ever happened to you, what is it? ",
            "---Going by your state now, where do you see yourself in 10 years? ",
        };
        _count = 0;
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        return _prompts[randomPromptIndex];
    }
    public List<string> GetListFromUser()
    {
        List<string>responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            _count += 1;
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);
            
        }
        return responses;             
    }
    public void RunListingActivity()
    {
        base.DisplaySpinnerIntroduction();
        base.ShowSpinner(5);
        Console.WriteLine("List as many responses as you can to the following prompt:");   
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in...");
        base.ShowCountDown(5);
        Console.WriteLine();
        List<string>responses = GetListFromUser();
        Console.WriteLine($"You have listed {_count} items.");
        Console.WriteLine();
        Console.WriteLine();
        base.DisplayCompletion();
        base.ShowSpinner(5);
        Console.WriteLine();
        base.DisplayEndingMessage();
        base.ShowSpinner(5);          
    }
}
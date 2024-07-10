public class GratitudeActivity : Activity
{
    // This activity will prompt the user to reflect on things they are grateful for.
    protected List<string> _gratitudePrompts;
    private int _count;
    public GratitudeActivity()
    {
        _name = "Gratitude Activity";
        _description = "This activity will help you reflect on the things you are grateful for in your life.";
        _gratitudePrompts = new List<string> {
            "---Think of a person you are grateful for and why?  ",
            "---Reflect on a recent experience that made you happy?  ",
            "---Consider something you own that you are thankful for?  ",
            "---Think about a personal strength you are grateful to have?  ",
            "---Ask yourself how often you thank those who help you?---",
            "---How would you feel if you helped someone and they are ungrateful?  ",
        };
    }
    public string GetRandomPrompts()
    {
        Random random = new Random();
        int gratitudePromptIndex = random.Next(_gratitudePrompts.Count);
        return _gratitudePrompts[gratitudePromptIndex];
    }
    public void DisplayPrompts()
    {
        base.DisplaySpinnerIntroduction();
        base.ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Take time and reflect on the following prompts and compare them with your current situation.");
        Console.WriteLine();
        Console.Write("Start your though process in....");
        base.ShowCountDown(5);
        Console.Clear();
        Console.WriteLine();
        for (int i = 0; i < _gratitudePrompts.Count; i++)
        {
            _count += 1;
            Console.Write(GetRandomPrompts());
            base.ShowSpinner(5);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($"You have just been shown {_count} gratitude prompts.");
        Console.WriteLine();
        base.DisplayCompletion();
        base.ShowSpinner(5);
        Console.WriteLine();
        base.DisplayEndingMessage();
        base.ShowSpinner(5);
    }  
}
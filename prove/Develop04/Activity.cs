using System.ComponentModel;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    public Activity()
    {         
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.\n");
    }
    public void DisplaySpinnerIntroduction()
    {
        Console.Write("Get ready...\n");
    }
    public void DisplayDescription()
    {
        Console.WriteLine($"{_description}\n");
    }
    public int DisplayDuration()
    {
        Console.Write($"How long in seconds do you wish your {_name} session to last? ");
        int time = int.Parse(Console.ReadLine());
        _duration = time;
        return _duration;     
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity");
    }
    public void DisplayCompletion()
    {
        Console.WriteLine("Well done!!");
    }
    public void ShowSpinner(int seconds)
    {  
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        List<string>animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("\\");
        animations.Add("-");
        animations.Add("/");
        animations.Add("|");
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animations.Count)
            {
                i = 0;
            }
        }
        {
            
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
   
}
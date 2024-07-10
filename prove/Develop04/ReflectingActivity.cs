public class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;
   
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you have to reflect on times when you have shown confidence, strength, and resillience. This will help you recognize your inner ability and how you can invoke it for other aspects of your life."; 
        _prompts = new List<string> {
            "---Think of a time when you did something really difficult.---",
            "---Imagine of a time you did something good.---",
            "---Think of a time you were applauded for succeeding in doing something.---",
            "---Ponder over a situation when you were a leader of a large group of people.---"       
        };
        _questions = new List<string> {
            ">What was the experience like?  ",
            ">What was good about the experience?  ",
            ">Can you do it again if given a chance?  ",
        };    
    }
    public string GetRandomPrompt()
    {  
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        return _prompts[randomPromptIndex];   
    }
    
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomQuestionIndex = random.Next(_questions.Count);
        return _questions[randomQuestionIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.Write(GetRandomPrompt());
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("When you are done thinking, press 'Enter' to continue ");
        Console.ReadLine();  
        Console.WriteLine();
        Console.WriteLine("Now ponder over each of these questions and figure out their relationship to this experience."); 
        Console.Write("You may begin in....");
        base.ShowCountDown(5);
        Console.Clear(); 
    }
    public void DisplayQuestion()
    {
        
        for (int i = 0; i < _questions.Count; i++)
        {
            Console.Write(GetRandomQuestion());
            base.ShowSpinner(5);
            Console.WriteLine();          
        }  
        Console.WriteLine();
        base.DisplayCompletion();
        base.ShowSpinner(5);
        Console.WriteLine();
        base.DisplayEndingMessage();
        base.ShowSpinner(5);  
    } 
    public void RunReflectingActivity()
    {
        base.DisplaySpinnerIntroduction();
        base.ShowSpinner(5);
        
    }   
    
}
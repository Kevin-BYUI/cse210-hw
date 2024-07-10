public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
       _name = "Breathing";
       _description = "This activity will help you to relax by walking you through breathing in, breathing out in a slow pace. Focus on this activity and rid your mind of any unnecessary destruction";   
    }
    public void RunBreathingActivity()
    {
        base.DisplaySpinnerIntroduction();
        base.ShowSpinner(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);    
        while (DateTime.Now < endTime)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Alright, Breathe in...");
                base.ShowCountDown(5);
                Console.WriteLine();
                Console.Write("Now Breathe out...");
                base.ShowCountDown(4);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        base.DisplayCompletion();
        base.ShowSpinner(5);
        Console.WriteLine();
        base.DisplayEndingMessage();
        base.ShowSpinner(5);


    }
}
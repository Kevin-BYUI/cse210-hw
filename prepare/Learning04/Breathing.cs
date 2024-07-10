
public class Breathing
{
    public Breathing()
    {
        

    }
    public void BreathingActivity()
    {
        Console.WriteLine("This activity will walk you through pacing your breathing. It will focus on controlling your breathing in and breathing out. Relax and focus on your breath.\n"
        );
        Console.Write("How long would you like to do this in seconds? ");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...\n\n");
        
       
        for (int i = time; i > 0; i--)
        {            
            Console.WriteLine($"Breathing in...{i}");
            Console.Write("\b \b");
            Thread.Sleep(1000); // wait for 1 second
            

            if (i > 1) // Ensure we don't print "Breathing out" after the last count
            {
                Console.WriteLine("Breathing out... (" + i + ")");
                Thread.Sleep(1000); // wait for 1 second
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("Done!");
    }
}


using System.Security.Cryptography.X509Certificates;
using System.Threading;

public class Animal
{
    
    
    public void ShowAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5); // Reduced time for demonstration
        List<string> animations = new List<string>
        {
            "|", "/", "-", "\\", "\\", "-", "/", "|"
        };
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

        Console.WriteLine();
        }
        
        
        
    }
    

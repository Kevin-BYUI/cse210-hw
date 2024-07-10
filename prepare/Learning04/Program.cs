using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
    {
    DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(50);
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
        Console.Write("What is your name? ");
       


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
        Console.WriteLine("Done!");

    }
            
        
            
        

        
    }
}
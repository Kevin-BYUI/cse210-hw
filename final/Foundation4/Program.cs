using System;

class Program
{
    static void Main(string[] args)
    {
        Running runningActivity = new Running("07 August, 2023", 50, 150);
        Cycling cyclingActivity = new Cycling("15 November, 2023", 120, 60);
        Swimming swimmingActivity = new Swimming("04 July, 2023", 90, 30);

        List<Activity> activities = new List<Activity> {runningActivity, cyclingActivity, swimmingActivity};
        foreach (Activity activity in activities)
        {
            Console.WriteLine();
            activity.GetSummary();
        }
    }
}
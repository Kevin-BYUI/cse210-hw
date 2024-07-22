public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int activityDurationInMinute, int numberOfLaps):
    base (date, activityDurationInMinute)
    {
        _numberOfLaps = numberOfLaps;
    }

    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }

    public override float GetDistance()
    {
        float length = _numberOfLaps * 50;
        return length * 1/1000;
       
        
    }

    public override float GetSpeed()
    {
        float time = base.GetActivityDurationInMinutes()/60;
        return GetDistance()/time;
    }

    public override float GetPace()
    {
        return 60/GetSpeed();
    }

    public override void GetSummary()
    {
         Console.WriteLine($"{base.GetDate()} {GetActivityName()}({base.GetActivityDurationInMinutes()} minutes) - Distance {GetDistance()}Km, Speed {GetSpeed()}Kmph, Pace: {GetPace()}min/km");   
    }
    
}
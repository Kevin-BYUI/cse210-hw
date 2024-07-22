public class Running : Activity
{
    
    private float _distanceInKm;

    public Running(string date, int activityDurationInMinutes, float distanceInKm):
    base (date, activityDurationInMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    public override float GetDistance()
    {
        return _distanceInKm;
    }

    public override float GetSpeed()
    {
        float time = base.GetActivityDurationInMinutes()/60; 
        return _distanceInKm/time;
    }

    public override float GetPace()
    {
        float paceTime = base.GetActivityDurationInMinutes();
        return paceTime/_distanceInKm;      
    }

    public override string GetActivityName()
    {
        return "Running";
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{base.GetDate()} {GetActivityName()}({base.GetActivityDurationInMinutes()} minutes) - Distance {GetDistance()}Km, Speed {GetSpeed()}Kmph, Pace: {GetPace()}min/km");   
    }
}
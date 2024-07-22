public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int activityDurationInMinutes, float speed):
    base (date, activityDurationInMinutes)
    {
        _speed = speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetDistance()
    {
        float time = base.GetActivityDurationInMinutes()/60;
        return _speed * time;
    }

    public override float GetPace()
    {
        return 60/_speed;
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{base.GetDate()} {GetActivityName()}({base.GetActivityDurationInMinutes()} minutes) - Distance {GetDistance()}Km, Speed {GetSpeed()}Kmph, Pace: {GetPace()}min/km");   
    }
}
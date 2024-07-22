public abstract class Activity
{
    private string _date;
    private int _activityDurationInMinutes;

    public Activity(string date, int activityDuration)
    {
        _activityDurationInMinutes = activityDuration;
        _date = date;
    }

    public string GetDate()
    {
        return _date;     
    }

    public float GetActivityDurationInMinutes()
    {
        return _activityDurationInMinutes;
    }

    public abstract string GetActivityName();


    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public abstract void GetSummary(); 
}
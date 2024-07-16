public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points):
    base (shortName, description, points)
    {


    }
    public override string GetShortName()
    {
        return _shortName;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"{_shortName}");
        
    }
    public override bool IsComplete()
    {
        return false;
        
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = "[ ]"; // Always unchecked since it's never complete
        return $"{completionStatus} | {_shortName} | ({_description})";
    }
}
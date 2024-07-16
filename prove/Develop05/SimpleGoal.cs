public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points):
    base (shortName, description, points)
    {
        _isComplete = false;      
    }
    public override string GetShortName()
    {
       return _shortName;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine(GetStringRepresentation());       
    }  
    public override bool IsComplete()
    {
        return _isComplete; 
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = _isComplete ? "[✓]" : "[ ]";
        return $"{completionStatus} | {_shortName} | ({_description}) | {_points}";
    }
}
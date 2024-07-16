using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus):
    base (shortName, description, points)
    {
       
        _target = target;
        _bonus = bonus;
       _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"{_shortName} - Progress: {_amountCompleted}/{_target}");
        
        if (_amountCompleted >= _target)
        {
            Console.WriteLine("Congratulations! You've completed the goal and earned a bonus.");
        }
        
    }
    public override string GetShortName()
    {
        return _shortName;
    }
    


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        string completionStatus = IsComplete() ? "[✓]" : "[ ]";
        return $"{completionStatus} | {_shortName} | ({_description}) | --- currently completed: {GetDetailsString()}";
    }
    public int GetBonus()
    {
        return _bonus;
    }

}
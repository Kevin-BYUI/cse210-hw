using System.Globalization;

public class WritingAssignment : Assignment
{
    private string _title = "";
    public WritingAssignment(string studentName, string topic, String title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return $"{base.GetSummary()}\n{_title}";
    }
}
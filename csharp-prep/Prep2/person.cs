public class Person
{
    public string _givenName;
    public string _familyName;
    public Person()
    {}
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName}, {_familyName}");      
    }
    public void ShowEaternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
}
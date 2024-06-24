public class Person
{
    public string _firstName;
    public string _lastName;
    public Person()
    {

    }
    public void ShowKenyaWay()
    {
        Console.WriteLine($"{_lastName} {_firstName}");
    }
    public void ShowAmericaWay()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }
}
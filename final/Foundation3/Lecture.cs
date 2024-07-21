
using System;
using System.Collections.Generic;
public class Lectures : Event
{
    private Person _speaker;
    private int _capacity;

    public Lectures(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime,
    Address address, Person speaker, int capacity): base (eventType, eventTitle, eventDescription, eventDate, eventTime, address)   
    {
        _speaker = speaker;
        _capacity = capacity;     
    }

    public Person GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void DisplayLectureDetails()
    {
        base.DisplayEventInformation();
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine($"Speaker Details:");
        Console.WriteLine(_speaker.DisplayPersonInformation());      
    }

}
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
public class Event
{
    private string _eventType;
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _address;

    public Event(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, Address address)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _address = address;
        _eventType = eventType;
    }

    public string GetEventType()
    {
        return _eventType;
    }
 
    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetEventDescription()
    {
        return _eventDescription;
    }

    public string GetEventDate()
    {
        return _eventDate;
    }

    public string GetEventTime()
    {
        return _eventTime;
    }

    public Address GetEventAddress()
    {
        return _address;
    }

    public void DisplayEventInformation()
    {
        Console.WriteLine($"Event Title: {_eventTitle}\nEvent Description: {_eventDescription}");
        Console.WriteLine($"Event Date: {_eventDate}\nEvent Time: {_eventTime}");
        Console.WriteLine($"Event Address: {_address.DisplayAddressDetails()}");
    }
   
}
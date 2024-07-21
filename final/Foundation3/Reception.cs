using System;
using System.Collections.Generic;
public class Receptions : Event
{
    private string _RSVPEmail;

    public Receptions(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, Address address, string RSVPEmail):
    base (eventType, eventTitle, eventDescription, eventDate, eventTime, address)
    {
        _RSVPEmail = RSVPEmail;
    }

    public string GetRSVPEmail()
    {
        return _RSVPEmail;
    }

    public void DisplayReceptionDetails()
    {
        base.DisplayEventInformation();
        Console.WriteLine("RSVP Email:");
        Console.WriteLine(_RSVPEmail);
    }

}
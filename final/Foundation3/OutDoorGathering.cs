using System;
using System.Collections.Generic;
public class OutDoorGatherings : Event
{
    private string _weatherForecat;

    public OutDoorGatherings(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, Address address, string weatherForecast):
    base (eventType, eventTitle, eventDescription, eventDate, eventTime, address)
    {
        _weatherForecat = weatherForecast;
    }

    public string GetWeatherForecats()
    {
        return _weatherForecat;
    }

    public void displayOutDoorGatehringDetails()
    {
        base.DisplayEventInformation();
        Console.WriteLine($"Weather Forecat:");
        Console.WriteLine(_weatherForecat);
    }


}
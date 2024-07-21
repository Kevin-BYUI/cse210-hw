using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lecture Event Details:");
        Address address = new Address("Grand BallRoom 1234", "Hilton", "New York", "USA");
        Person speaker = new Person("Simon Sinek", "British-American", 20);
        Lectures lectures =new Lectures("Lectures", "Leading with Purpose", "An engaging and inspiring talk by Simon Sinek on the importance of finding and following your 'why'. Simon will delve into how leaders can inspire action and create meaningful change in their organizations by leading with purpose.", "September 15, 2024", "10:00 AM - 12:00 PM", address, speaker, 500);
        lectures.DisplayLectureDetails();
        Console.WriteLine();
        
        Console.WriteLine("Receptione Event Details:");
        Address address1 = new Address("The BallRoom 1252", "Carlton", "San Francisco", "USA");
        Receptions receptions = new Receptions("Reception", "Annual Charity Gala Reception", "Join us for an elegant evening of dining, networking, and entertainment at the Annual Charity Gala Reception. This event brings together philanthropists, business leaders, and community members to support our ongoing charitable initiatives. Enjoy a keynote speech by our special guest, Arianna Huffington, followed by live music and a silent auction.", "December 1, 2024", "6:00 PM - 10:00 PM",address1, "Thank you for the invitation to the Annual Charity Gala Reception on December 1, 2024, at the Ritz-Carlton Hotel, I am please to cofirm my attendance!");
        receptions.DisplayReceptionDetails();
        Console.WriteLine();

        Console.WriteLine("Out Door Event Details:");
        Address address2 = new Address("Central Park 1210", "Great Lawn", "New York", "USA");
        OutDoorGatherings outDoorGatherings = new OutDoorGatherings("Out Door Gatherings", "Outdoor Summer Picnic", "Enjoy a relaxing day outdoors at our annual Summer Picnic. This family-friendly event features delicious food, fun games, and live music. Bring your picnic blanket and join us for a day of community and celebration. Activities include a barbecue, a bouncy castle for kids, and a talent show.", "August 20, 2024", "11:00 AM - 4:00 PM", address2, "The weather is expected to be sunny with a high of 85°F (29°C) and a light breeze. Please bring sunscreen, a hat, and stay hydrated.");
        outDoorGatherings.displayOutDoorGatehringDetails();
        Console.WriteLine();
       
        Console.WriteLine("Short Descriptions:");
        Console.WriteLine($"Type: {lectures.GetEventType()}\nTitle: {lectures.GetEventTitle()}\nDate: {lectures.GetEventDate()}");
        Console.WriteLine();
        
        Console.WriteLine($"Type: {receptions.GetEventType()}\nTitle: {receptions.GetEventTitle()}\nDate: {receptions.GetEventDate()}");
       
        Console.WriteLine();
        Console.WriteLine($"Type: {outDoorGatherings.GetEventType()}\nTitle: {outDoorGatherings.GetEventTitle()}\nDate: {outDoorGatherings.GetEventDate()}");
    }
}
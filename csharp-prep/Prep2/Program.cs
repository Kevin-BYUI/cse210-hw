using System;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person
        {
            _firstName = "Kevin",
            _lastName = "Ogutu",
        };
        person.ShowKenyaWay();
        person.ShowAmericaWay();

        Home home = new Home
        {
            _floorHeight = 60,
            _floorWidth = 50,
        };
        double floorArea = home.ShowArea();
        Console.WriteLine($"The area of the floor is {floorArea} m^2");

        Office office = new Office
        {
            _area = new Home
            {
                _floorHeight = 43,
                _floorWidth = 25,
            },
            _officeOwner = "Kevin Ogutu",
            _kenyanStyle = new Person
            {
                _firstName = "Kevin",
                _lastName = "Ogutu",
            }
        };
        Console.WriteLine($"Office owner: {office._officeOwner}");
        Console.WriteLine($"Office area: {office._area.ShowArea()} m^2");
        office._kenyanStyle.ShowKenyaWay();
        
    }    
    
   
}   
            
        
        
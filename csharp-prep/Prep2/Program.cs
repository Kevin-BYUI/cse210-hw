using System;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Blind kitchen = new Blind
        {
            _color = "yellow",
            _height = 20,
            _width = 30,
        };
        Blind livingRoom = new Blind
        {
            _height = 23,
            _width = 50,
        };
        Blind livingHouse=new Blind
        {
            _height = 45,
            _width = 21,
        };

        House kevinsHouse = new House();
        kevinsHouse._blinds.Add(kitchen);
        kevinsHouse._blinds.Add(livingHouse);
        kevinsHouse._blinds.Add(livingRoom);

        Console.WriteLine($"Kevin's living room area is {kevinsHouse._blinds[2].GetArea()}");     
    }
    
}
        
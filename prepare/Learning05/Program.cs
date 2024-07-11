using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("White", 25);
        Rectangle rectangle = new Rectangle("Yellow", 15, 20);
        Circle circle = new Circle("Blue", 14);
        
        DisplayInformatin(square);
        DisplayInformatin(circle);
        DisplayInformatin(rectangle);
    }
    public static void DisplayInformatin(Shape shape)
    {
        Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea():f2}");
    }
}
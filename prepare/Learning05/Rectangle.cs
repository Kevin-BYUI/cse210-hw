public class Rectangle : Shape
{
    public double _length;
    public double _height;
    public Rectangle(string color, double length, double height):base(color)
    {
        _length = length;
        _height = height;
    }

    public void SetLength(double length)
    {
        _length = length;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetHeight(double height)
    {
        _height = height;
    }
    public double GetHeight()
    {
        return _height;
    }
    public override double GetArea()
    {
        return _height * _length;
    }
    public override string GetColor()
    {
        return _color;
    }
}
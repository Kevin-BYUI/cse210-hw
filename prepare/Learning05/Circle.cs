public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius):base(color)
    {
        _radius = radius;
    }


    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
    public override string GetColor()
    {
        return _color;
    }
}
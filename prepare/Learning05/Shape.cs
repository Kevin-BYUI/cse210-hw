public abstract class Shape
{
    protected string _color = "";
    public Shape(string color)
    {
        _color = color;
    }
   
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract string GetColor();
    
    public abstract double GetArea();
    
             
    
   
}
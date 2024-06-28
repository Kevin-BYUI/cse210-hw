public class Dress
{
    public string _color;
    public string _design;
    public Dress()
    {

    }
    public string ShowOrigin()
    {
        return ($"{_color} {_design}");    
    }
}
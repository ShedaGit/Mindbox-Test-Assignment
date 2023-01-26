namespace ShapesLibrary;
public class Circle : IShape
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        this._radius = radius;
    }

    public double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}

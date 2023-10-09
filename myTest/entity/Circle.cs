using myTest.@enum;

namespace myTest.entity;

public class Circle : IShape
{
    public double CenterX { get; set; }
    public double CenterY { get; set; }
    public double Radius { get; set; }

    public Circle(double x, double y, double r)
    {
        CenterX = x;
        CenterY = y;
        Radius = r;
    }

    public Shape GetName()
    {
        return Shape.Circle;
    }
}
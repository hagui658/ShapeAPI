using myTest.@enum;

namespace myTest.entity;

public class Rectangle : IShape
{
    public double CenterX { get; set; }
    public double CenterY { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double x, double y, double w, double h)
    {
        CenterX = x;
        CenterY = y;
        Width = w;
        Height = h;
    }

    public Shape GetName()
    {
        return Shape.Rectangle;
    }
}
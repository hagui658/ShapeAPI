using myTest.entity;

namespace myTest.factory;

public class ShapeFactory : IShapeFactory
{
    public IShape CreateCircle(double x, double y, double radius)
    {
        return new Circle(x, y, radius);
    }

    public IShape CreateRectangle(double x, double y, double width, double height)
    {
        return new Rectangle(x, y, width, height);
    }
}
using myTest.entity;

namespace myTest.factory;

public interface IShapeFactory
{
    IShape CreateCircle(double x, double y, double radius);
    IShape CreateRectangle(double x, double y, double width, double height);
}
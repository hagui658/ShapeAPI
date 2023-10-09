using myTest.entity;

namespace myTest.util;

public static class CloneUtil
{
    public static IShape CloneShape(IShape original)
    {
        return original switch
        {
            Circle circle => new Circle(circle.CenterX, circle.CenterY, circle.Radius),
            Rectangle rectangle => new Rectangle(rectangle.CenterX, rectangle.CenterY, rectangle.Width,
                rectangle.Height),
            _ => original
        };
    }
}
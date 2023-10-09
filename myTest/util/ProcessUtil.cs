using myTest.entity;

namespace myTest.util;

public static class ProcessUtil
{
    public static IShape Process(IShape shape, object[] properties)
    {
        if (properties == null) throw new ArgumentNullException(nameof(properties));
        return properties switch
        {
            { Length: 3 } => ProcessCircle(shape, properties),
            { Length: 4 } => ProcessRectangle(shape, properties),
            _ => shape
        };
    }
    
    private static IShape ProcessCircle(IShape circle, object[] properties)
    {
        if (properties == null) throw new ArgumentNullException(nameof(properties));
        if (circle is not Circle circleShape) throw new Exception();
        var centerX = (double)properties[0];
        var centerY = (double)properties[1];
        var radius = (double)properties[2];

        circleShape.CenterX = centerX;
        circleShape.CenterY = centerY;
        circleShape.Radius = radius;

        return circleShape;
    }
    
    private static IShape ProcessRectangle(IShape rectangle, object[] properties)
    {
        if (properties == null) throw new ArgumentNullException(nameof(properties));
        if (rectangle is not Rectangle rectangleShape) throw new Exception();
        var centerX = (double)properties[0];
        var centerY = (double)properties[1];
        var width = (double)properties[2];
        var height = (double)properties[3];

        rectangleShape.CenterX = centerX;
        rectangleShape.CenterY = centerY;
        rectangleShape.Width = width;
        rectangleShape.Height = height;

        return rectangleShape;
    }
}
using myTest.dto;
using myTest.entity;
using myTest.factory;
using myTest.strategy;

namespace myTest.services.serviceImpl;

public class ShapeService : IShapeService
{
    public string CompareShapes(List<ShapeDto>? shapes)
    {
        IShape? circle = null;
        IShape? rectangle = null;

        if (shapes == null || !shapes.Any())
        {
            return "No shapes to compare.";
        }
        
        foreach (var shape in shapes)
        {
            switch (shape.shapeType)
            {
                case "circle":
                {
                    circle = CreateCircle(shape);
                    break;
                }
                case "rectangle":
                {
                    rectangle = CreateRectangle(shape);
                    break;
                }
            }
        }


        ActionResult Strategy(IShape shapeA, IShape shapeB)
        {
            var actionResult = new InterActionLogic().Logic(shapeA, shapeB);
            return actionResult;
        }
        
        var result = ActionExecute.Executor(circle!, rectangle!, Strategy);

        return result;
    }
    
    private static IShape CreateCircle(ShapeDto shape)
    {
        return new ShapeFactory().CreateCircle(shape.CenterX, shape.CenterY, shape.Radius);
    }
    
    private static IShape CreateRectangle(ShapeDto shape)
    {
        return new ShapeFactory().CreateRectangle(shape.X, shape.Y, shape.Width, shape.Height);
    }
}
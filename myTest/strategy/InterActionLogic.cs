using myTest.entity;
using myTest.@enum;
using myTest.factory;

namespace myTest.strategy;

public class InterActionLogic
{
    private readonly Dictionary<string, Func<IShape, IShape, ActionResult>> _map;

    public InterActionLogic()
    {
        _map = new Dictionary<string, Func<IShape, IShape, ActionResult>>
        {
            {"Circle-Rectangle", HandleCircleRectangleInteraction},
        };
    }

    private ActionResult HandleCircleRectangleInteraction(IShape shapeA, IShape shapeB)
    {
        var circleA = (Circle) shapeA;
        var rectangleB = (Rectangle) shapeB;
        var centerX = circleA.CenterX;
        var centerY = circleA.CenterY;
        var radius = circleA.Radius;

        var rectCenterX = rectangleB.CenterX;
        var rectCenterY = rectangleB.CenterY;
        var halfWidth = rectangleB.Width / 2.0;
        var halfHeight = rectangleB.Height / 2.0;
        
        var dist = Math.Sqrt(Math.Pow(centerX - rectCenterX, 2) + Math.Pow(centerY - rectCenterY, 2));
        var diag = Math.Sqrt(Math.Pow(halfWidth, 2) + Math.Pow(halfHeight, 2));

        if (halfWidth > dist + radius)
        {
            return ActionResultFactory.Create(ActionType.Contain, shapeA, shapeB);
        }

        if (radius > diag + dist)
        {
            return ActionResultFactory.Create(ActionType.Contain, shapeB, shapeA);
        }

        if (dist > diag + radius)
        {
            return ActionResultFactory.Create(ActionType.Disjoint, shapeA, shapeB);
        }

        return ActionResultFactory.Create(ActionType.Intersect, shapeA, shapeB);
    }


    public ActionResult Logic(IShape shapeA, IShape shapeB)
    {
        var key = $"{shapeA.GetName()}-{shapeB.GetName()}";
        if (_map.ContainsKey(key))
        {
            return _map[key](shapeA, shapeB);
        }

        throw new Exception("Unsupported shape combination");
    }
}
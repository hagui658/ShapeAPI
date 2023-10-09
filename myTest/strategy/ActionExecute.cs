using myTest.entity;
using myTest.strategy.@delegate;

namespace myTest.strategy;

public static class ActionExecute
{
    public static string Executor(IShape shapeA, IShape shapeB, ActionStrategy strategy)
    {
        var result = strategy(shapeA, shapeB);
        var actionResult = new ActionResult
        {
            Type = result.Type,
            ShapeA = result.ShapeA,
            ShapeB = result.ShapeB
        };
        return actionResult.GetFormattedResult();
    }
}
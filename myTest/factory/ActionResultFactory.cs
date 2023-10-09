using myTest.entity;
using myTest.@enum;
using myTest.strategy;

namespace myTest.factory;

public static class ActionResultFactory
{
    public static ActionResult Create(ActionType type, IShape shapeA, IShape shapeB)
    {
        return new ActionResult
        {
            Type = type,
            ShapeA = shapeA,
            ShapeB = shapeB
        };
    }
}
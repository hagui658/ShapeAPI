using myTest.entity;
using myTest.strategy.@delegate;
using myTest.util;

namespace myTest.strategy;

public class IntersectStrategy : IActionStrategies
{
    public event Func<IShape, object[]>? GetShape;
    
    public ActionResult Strategy(IShape shapeA, IShape shapeB,InteractionLogic interaction)
    {
        var shapeAProperty = GetShape?.Invoke(shapeA);
        var shapeBProperty = GetShape?.Invoke(shapeB);

        var shapeACopy = CloneUtil.CloneShape(shapeA);
        var shapeBCopy = CloneUtil.CloneShape(shapeB);
        
        var shape1 = ProcessUtil.Process(shapeACopy, shapeAProperty ?? throw new InvalidOperationException());
        var shape2 = ProcessUtil.Process(shapeBCopy, shapeBProperty ?? throw new InvalidOperationException());

       
        var result = interaction(shape1, shape2);

        return result;
    }
}
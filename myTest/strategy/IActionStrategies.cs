using myTest.entity;
using myTest.strategy.@delegate;

namespace myTest.strategy;

public interface IActionStrategies
{
    public ActionResult Strategy(IShape shapeA, IShape shapeB,InteractionLogic interaction);
}
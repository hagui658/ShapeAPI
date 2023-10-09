using myTest.entity;

namespace myTest.strategy.@delegate;

public delegate ActionResult ActionStrategy(IShape shapeA, IShape shapeB);

public delegate ActionResult InteractionLogic(IShape shapeA, IShape shapeB);
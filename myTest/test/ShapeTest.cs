using myTest.entity;
using myTest.strategy;
using NUnit.Framework;

namespace myTest.test;

[TestFixture]
public class ShapeTest
{
    [Test]
    public void TestStrategy1()
    {
        var circle = new Circle(1, 1, 5);
        var rectangle = new Rectangle(1, 1, 1, 1);

        ActionResult Strategy(IShape shapeA, IShape shapeB)
        {
            var actionResult = new InterActionLogic().Logic(shapeA, shapeB);
            return actionResult;
        }

        var result = ActionExecute.Executor(circle, rectangle, Strategy);

        Assert.AreEqual("Circle is Contain Rectangle", result);
    }
}
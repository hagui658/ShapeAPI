using myTest.entity;
using myTest.@enum;

namespace myTest.strategy;

public struct ActionResult
{
    public ActionType Type { get; set; }
    public IShape ShapeA { get; set; }
    public IShape ShapeB { get; set; }
    
    public string GetFormattedResult()
    {
        var shapeAName = ShapeA.GetName(); 
        var shapeBName = ShapeB.GetName(); 

        return $"{shapeAName} is {Type} {shapeBName}";
    }
}

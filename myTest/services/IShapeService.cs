using myTest.dto;

namespace myTest.services;

public interface IShapeService
{
    string CompareShapes(List<ShapeDto> shapes);
}
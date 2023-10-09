using Microsoft.AspNetCore.Mvc;
using myTest.dto;
using myTest.services;

namespace myTest.controller;

[ApiController]
[Route("api/shapes")]
public class ShapeController : ControllerBase
{
    private readonly IShapeService _shapeService;

    public ShapeController(IShapeService shapeService)
    {
        _shapeService = shapeService;
    }

    [HttpPost("compare")]
    public ActionResult<string> CompareShape([FromBody] List<ShapeDto> shapes)
    {
        var result = _shapeService.CompareShapes(shapes);

        return Ok(result);
    }
}
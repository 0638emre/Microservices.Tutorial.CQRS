using API.Mediatr_CQRS.Commands.Request;
using API.Mediatr_CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CqrsMediatrController(IMediator _mediator) : ControllerBase
{
    [HttpGet("[action]")]
    public IActionResult MediatrGetAllProducts([FromQuery] GetAllProductQueryRequest request)
     => Ok(_mediator.Send(request));
    
    [HttpGet("{ProductId}")]
    public IActionResult MediatrGetById([FromRoute] GetByIdProductQueryRequest request)
     => Ok(_mediator.Send(request));
    
    [HttpPost("[action]")]
    public IActionResult MediatrCreateProduct([FromBody] CreateProductCommandRequest request)
     => Ok(_mediator.Send(request));
    
    [HttpDelete("{ProductId}")]
    public IActionResult MediatrDeleteProduct([FromRoute] DeleteProductCommandRequest request)
     => Ok(_mediator.Send(request));
    
}
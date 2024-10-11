using API.Manual_CQRS.Commands.Requests;
using API.Manual_CQRS.Handlers.Commands;
using API.Manual_CQRS.Handlers.Queries;
using API.Manual_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

// [ApiController]
// [Route("[controller]")]
// public class CQRSManualController(GetAllProductQueryHandler getAllProductQueryHandler, GetByIdProductQueryHandler getByIdProductQueryHandler
// , CreateProductCommandHandler createProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler) : ControllerBase
// {
//     [HttpGet("[action]")]
//     public IActionResult GetAllProducts([FromQuery] GetAllProductQueryRequest request)
//      => Ok(getAllProductQueryHandler.GetAllProduct(request));
//     
//     [HttpGet("{ProductId}")]
//     public IActionResult GetById([FromRoute] GetByIdProductQueryRequest request)
//      => Ok(getByIdProductQueryHandler.GetByIdProduct(request));
//     
//     [HttpPost("[action]")]
//     public IActionResult CreateProduct([FromBody] CreateProductCommandRequest request)
//      => Ok(createProductCommandHandler.CreateProduct(request));
//     
//     [HttpDelete("{ProductId}")]
//     public IActionResult DeleteProduct([FromRoute] DeleteProductCommandRequest request)
//      => Ok(deleteProductCommandHandler.DeleteProduct(request));
//     
// }
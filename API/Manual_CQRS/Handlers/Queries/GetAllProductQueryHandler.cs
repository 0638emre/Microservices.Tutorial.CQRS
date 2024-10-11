using API.Manual_CQRS.Queries.Requests;
using API.Manual_CQRS.Queries.Responses;
using API.Modals;

namespace API.Manual_CQRS.Handlers.Queries;

public class GetAllProductQueryHandler
{
    public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest request)
    {
        return ApplicationDbContext.Products.Select(p => new GetAllProductQueryResponse
        {
            ProductId = p.Id,
            CreateTime = p.CreateTime,
            Name = p.Name,
            Price = p.Price,
            Quantity = p.Quantity,
            
        }).ToList();
    } 
}
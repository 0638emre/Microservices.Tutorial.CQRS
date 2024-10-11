using API.Manual_CQRS.Queries.Requests;
using API.Manual_CQRS.Queries.Responses;
using API.Modals;

namespace API.Manual_CQRS.Handlers.Queries;

public class GetByIdProductQueryHandler
{
    public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
    {
        var product = ApplicationDbContext.Products.FirstOrDefault(p=>p.Id.Equals(request.ProductId));
        GetByIdProductQueryResponse response = new GetByIdProductQueryResponse(); 

        if (product != null)
        {
            response.ProductId = product.Id;
            response.Name = product.Name;
            response.Price = product.Price;
            response.Quantity = product.Quantity;
            response.CreateTime = product.CreateTime;
        }

        return response;
    }
}
using API.Mediatr_CQRS.Queries.Request;
using API.Mediatr_CQRS.Queries.Response;
using API.Modals;
using MediatR;

namespace API.Mediatr_CQRS.Handlers.Response;

public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
{
    public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
    {
        var p = ApplicationDbContext.Products.Where(p => p.Id.Equals(request.ProductId)).FirstOrDefault();

        return new()
        {
            ProductId = p.Id,
            Price = p.Price,
            Name = p.Name,
            Quantity = p.Quantity,
            CreateTime = p.CreateTime,
        };
    }
}
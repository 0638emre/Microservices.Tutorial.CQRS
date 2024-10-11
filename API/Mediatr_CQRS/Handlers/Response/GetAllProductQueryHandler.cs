using API.Mediatr_CQRS.Queries.Request;
using API.Mediatr_CQRS.Queries.Response;
using API.Modals;
using MediatR;

namespace API.Mediatr_CQRS.Handlers.Response;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
{
    public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
    {
        var datas = ApplicationDbContext.Products.ToList();
        
        return datas.Select(p => new GetAllProductQueryResponse
        {
            ProductId = p.Id,
            Price = p.Price,
            Name = p.Name,
            Quantity = p.Quantity,
            CreateTime = p.CreateTime,
        }).ToList();
    }
}
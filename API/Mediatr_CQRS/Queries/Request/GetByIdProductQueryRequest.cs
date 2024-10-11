using API.Mediatr_CQRS.Queries.Response;
using MediatR;

namespace API.Mediatr_CQRS.Queries.Request;

public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
{
    public Guid ProductId { get; set; }
}
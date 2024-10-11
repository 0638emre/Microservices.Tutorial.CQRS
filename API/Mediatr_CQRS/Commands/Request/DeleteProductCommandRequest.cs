using API.Mediatr_CQRS.Commands.Response;
using MediatR;

namespace API.Mediatr_CQRS.Commands.Request;

public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
{
    public Guid ProductId { get; set; }

}
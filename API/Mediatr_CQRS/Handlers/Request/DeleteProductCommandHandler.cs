using API.Mediatr_CQRS.Commands.Request;
using API.Mediatr_CQRS.Commands.Response;
using API.Modals;
using MediatR;

namespace API.Mediatr_CQRS.Handlers.Request;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
{
    public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = ApplicationDbContext.Products.FirstOrDefault(p => p.Id == request.ProductId);

        if (product is not null)
        {
            ApplicationDbContext.Products.Remove(product);

            return new DeleteProductCommandResponse()
            {
                IsSuccess = true
            };
        }
        
        return new DeleteProductCommandResponse()
        {
            IsSuccess = false
        };
    }
}
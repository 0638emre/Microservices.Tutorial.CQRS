using API.Mediatr_CQRS.Commands.Request;
using API.Mediatr_CQRS.Commands.Response;
using API.Modals;
using MediatR;

namespace API.Mediatr_CQRS.Handlers.Request;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
{
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var productId = Guid.NewGuid();
        ApplicationDbContext.Products.Add(new Product()
        {
            Id = productId,
            Name = request.Name,
            Price = request.Price,
            Quantity = request.Quantity,
            CreateTime = DateTime.Now
        });

        return new()
        {
            IsSuccess = true,
            ProductId = productId
        };

    }
}
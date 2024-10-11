using API.Manual_CQRS.Commands.Requests;
using API.Manual_CQRS.Commands.Responses;
using API.Modals;

namespace API.Manual_CQRS.Handlers.Commands;

public class CreateProductCommandHandler
{
    public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
    {
        var id = Guid.NewGuid();
        ApplicationDbContext.Products.Add(new Product()
        {
            Name = request.Name,
            Id = id,
            Price = request.Price,
            CreateTime = DateTime.Now
        });

        return new()
        {
            ProductId = id,
            IsSuccess = true
        };
    }
}
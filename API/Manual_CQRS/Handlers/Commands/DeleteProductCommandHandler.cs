using API.Manual_CQRS.Commands.Requests;
using API.Manual_CQRS.Commands.Responses;
using API.Modals;

namespace API.Manual_CQRS.Handlers.Commands;

public class DeleteProductCommandHandler
{
    public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
    {
        var product = ApplicationDbContext.Products.FirstOrDefault(p=> p.Id.Equals(request.ProductId));

        if (product != null)
        {
            ApplicationDbContext.Products.Remove(product);
        }
        
        return new()
        {
            IsSuccess = true
        };
    }
}
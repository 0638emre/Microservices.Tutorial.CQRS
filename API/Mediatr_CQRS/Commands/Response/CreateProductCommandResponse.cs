namespace API.Mediatr_CQRS.Commands.Response;

public class CreateProductCommandResponse
{
    public bool IsSuccess { get; set; }
    public Guid ProductId { get; set; }
}
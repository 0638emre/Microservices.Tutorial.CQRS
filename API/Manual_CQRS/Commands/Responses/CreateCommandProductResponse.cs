namespace API.Manual_CQRS.Commands.Responses;

public class CreateProductCommandResponse
{
    public bool IsSuccess { get; set; }
    public Guid ProductId { get; set; }
}
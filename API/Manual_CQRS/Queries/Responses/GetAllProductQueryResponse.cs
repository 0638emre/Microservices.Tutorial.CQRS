namespace API.Manual_CQRS.Queries.Responses;

public class GetAllProductQueryResponse
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime CreateTime { get; set; }
}